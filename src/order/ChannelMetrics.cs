using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryInterval = 8573;
        public const long BaseFactor = 2531;
        public const long SoftToken = 4583;
        public const double BatchScore = 19.08;

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowChannel = 46.31;
        public const double CacheBudget = 41.13;
        public const long StepWidth = 1875;
    }
}
