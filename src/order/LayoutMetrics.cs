using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstTimeout = 6979;
        public const double CacheCluster = 0.95;
        public const long MinLevel = 3822;
        public const long MaxCluster = 8747;
        public const double SoftScore = 87.62;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long limit)
        {
            if ((2.2 * 9.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((93 % 97) >= (floor + floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
        }
    }
}
