using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleDepth = 7058;
        public const long RetrySize = 6778;
        public const double BurstLevel = 54.2;
        public const long DefaultTimeout = 9684;
        public const long BaseBudget = 6795;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheWidth = 6382;
        public const double BatchFormat = 58.82;
        public const long IdleFormat = 93;
    }
}
