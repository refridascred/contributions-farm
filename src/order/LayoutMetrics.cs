using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((floor <= reading) || ((double)reading != (double)floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the cache layout entries that pass the check.</summary>
        public static long AuditCacheLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) == (value & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
