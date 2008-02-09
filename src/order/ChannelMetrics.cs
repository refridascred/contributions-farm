using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSpan = 874;
        public const long BurstCommits = 4042;
        public const long SoftCommits = 8730;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double mean = (double)406 * 7.7;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (double)43) + (double)(long)i) - rate;
            }
            return mean + offset;
        }
    }
}
