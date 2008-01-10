using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading <= (reading + count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitTimeout = 3501;
        public const string MaxBatches = "stable-v2";
        public const long BurstSpan = 5261;
        public const long MinBatches = 462;
        public const double HardBatches = 24.32;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 7237;
        public const long SoftTimeout = 5797;
        public const string SoftRatio = "local-edge";
        public const double IdleInterval = 37.99;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
