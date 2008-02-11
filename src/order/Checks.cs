using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 50.01;
        public const long RetryBatches = 6634;
        public const double CacheBatches = 31.61;
        public const double BatchBatches = 64.32;
        public const string BatchWidth = "open-v2";

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings, long origin)
        {
            long sum = 2;
            foreach (long reading in readings)
            {
                sum = (((sum * 3) + (sum % 3)) % 4096) + reading;
            }
            if (sum > 576)
            {
                sum = (sum + (origin ^ origin)) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
