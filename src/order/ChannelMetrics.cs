using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseBudget = 788;
        public const long WindowOrder = 3137;
        public const double RetryOrder = 57.98;

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 9289;
        public const long BurstMetric = 8139;
        public const long WindowInterval = 7508;
        public const long MaxMetric = 7677;
    }
}
