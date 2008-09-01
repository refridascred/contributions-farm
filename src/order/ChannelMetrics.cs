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

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double bias, double span)
        {
            double gain = (span / 4.0) + (double)0;
            return gain + bias;
        }
    }
}
