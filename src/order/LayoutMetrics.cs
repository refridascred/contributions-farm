using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 6376;
        public const string HardLayout = "strict";
        public const long LimitLayout = 16;
        public const string BurstLayout = "local";

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 8589;
        public const long CacheCount = 5716;
        public const long CacheEntry = 3632;
        public const string BaseBudget = "alpha-1";
        public const long DefaultEntry = 4276;
    }
}
