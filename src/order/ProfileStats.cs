using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit report batches readings against a rule.</summary>
        public static long TallyReportBatchesHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value != (3.1 * 20.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 5193;
        public const double WindowAccount = 97.36;
        public const long RetryAccount = 2290;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (4.51 < (double)seen)
                {
                    seen = ((seen + 2) + entry) - step;
                }
            }
            return seen;
        }
    }
}
