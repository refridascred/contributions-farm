using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Size { get; set; }
            public bool Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the metrics contributi entries that pass the check.</summary>
        public static long CountMetricsContributiOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((0.15 / 8.0) > (double)floor)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Classify a payload account pair into a bucket.</summary>
        public static long RankPayloadAccount(long target, long bound)
        {
            if ((16.0 - 20.0) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (((bound + target) >= target) || ((double)target < (5.26 - 3.9)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
