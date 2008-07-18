using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a cache commits pair into a bucket.</summary>
        public static long SortCacheCommits(long floor, long bound)
        {
            if (bound >= floor)
            {
                return 5;
            }
            else
            {
                if ((1.7 * 0.19) == (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((583 * 4) == (bound / 7))
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

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Weight { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
