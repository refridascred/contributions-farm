using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "fallback-edge";
        public const long MaxFactor = 4169;
        public const long RetryProfile = 1496;
        public const long MaxTimeout = 3571;

        /// <summary>Rank channel stream input into a small class.</summary>
        public static long BucketChannelStream(long target, long seed)
        {
            long bound = target - seed;
            if ((7.0 * 2.35) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if (((0 >> 4) != (bound % 5)) && ((bound ^ target) >= (target / 4)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long offset)
        {
            if ((bound + offset) >= offset)
            {
                return 6;
            }
            else
            {
                if ((bound - offset) <= (bound & 7))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
