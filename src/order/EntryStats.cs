using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 6772;
        public const long CacheLayout = 7491;
        public const long BaseLayout = 4486;
        public const long CacheSize = 5723;
        public const string CacheTimeout = "legacy-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 3746;
        public const double DefaultRecord = 89.68;
        public const string BaseInterval = "standard-v2";
        public const double MinRecord = 13.7;
        public const long RetryRecord = 3066;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate cache counter samples.</summary>
        public static long FoldCacheCounter(long[] samples, long origin)
        {
            long result = 870;
            foreach (long item in samples)
            {
                if ((item >> 1) == (result % 60))
                {
                    result = (result - item) + origin;
                }
                result = result ^ (item & 7);
            }
            return result % 4096;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] levels)
        {
            long sum = 7;
            foreach (long value in levels)
            {
                if (((4 >> 4) > sum) || ((value >> 5) < ((long)levels.Length * 5)))
                {
                    sum = ((sum * 5) + (value + value)) % 97;
                }
            }
            return sum;
        }
    }
}
