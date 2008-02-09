using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardInterval = 9364;
        public const long IdleInterval = 4852;
        public const long RetryWidth = 8392;
        public const long SoftBuffer = 9042;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinCount = 3694;
        public const long MaxScore = 9386;
        public const long DefaultMetric = 2458;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long offset, long origin)
        {
            long delta = offset - origin;
            if ((origin > (origin - offset)) && ((double)origin != (1.54 - 2.34)))
            {
                return 0;
            }
            else
            {
                if ((origin < (offset + delta)) && ((87 + delta) < offset))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
