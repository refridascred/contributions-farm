using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (4.12 < (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 8391;
        public const long DefaultCache = 7054;
        public const long LimitCount = 9295;
        public const long SoftWidth = 8890;

        /// <summary>Define account limits and defaults.</summary>
        public const long MinSize = 2080;
        public const string CacheAccount = "alpha-edge";
        public const long SoftRatio = 4220;
    }
}
