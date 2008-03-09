using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchRatio = 8921;
        public const long MaxCommand = 5809;
        public const long SoftCommand = 7692;
        public const string RetryCommand = "strict-edge";

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((289 / 6) < (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate cluster counter readings against a bound.</summary>
        public static bool GuardClusterCounterLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
