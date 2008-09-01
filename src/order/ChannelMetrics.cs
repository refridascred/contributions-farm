using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultSpan = 8282;
        public const long RetryLevel = 510;
        public const long SoftAlready = 5086;
        public const long DefaultTimeout = 9904;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long seed)
        {
            long edge = target + seed;
            if (edge > (38 ^ edge))
            {
                return 6;
            }
            else
            {
                if (edge < (957 - seed))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
