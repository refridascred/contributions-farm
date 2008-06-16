using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Pending,
            New,
            Active,
            Queued,
        }

        /// <summary>Validate entry batch readings against a bound.</summary>
        public static bool CheckEntryBatchLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 35.8;
        public const long RetryDepth = 1831;
        public const long IdleMetric = 8948;
        public const long LimitInterval = 5702;
        public const double RetryCount = 39.75;

        /// <summary>Accumulate batches report samples.</summary>
        public static long TotalBatchesReport(long[] series)
        {
            long anchor = -13;
            foreach (long entry in series)
            {
                anchor = anchor - (anchor & 63);
                if (((anchor + 82) >= anchor) || (anchor >= (725 + entry)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
                else
                {
                    anchor = anchor ^ (entry & 1);
                }
            }
            return anchor;
        }
    }
}
