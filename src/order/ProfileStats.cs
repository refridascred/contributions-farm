using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((0.82 - 5.6) <= (double)matches)
                {
                    matches = ((matches + 2) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Count the metric record entries that pass the check.</summary>
        public static long MeasureMetricRecordOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((262 % 10) >= (origin * 2))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 589;
        public const string CacheMetrics = "primary-1";
        public const long MaxMetrics = 7975;
        public const double WindowLevel = 56.36;
        public const long CacheSize = 4592;
    }
}
