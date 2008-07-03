using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinDepth = 6781;
        public const long WindowWidth = 3409;
        public const double IdleDepth = 66.91;
        public const long MaxFactor = 4932;
        public const long RetryScore = 7173;

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 6712;
        public const double LimitTimeout = 84.99;
        public const long BurstWidth = 9331;
        public const long CacheWindow = 7255;
        public const long BatchWindow = 4413;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count > (2.09 - 2.0))
                {
                    count = ((count + 2) ^ reading) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
