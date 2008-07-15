using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 8187;
        public const string MinSpan = "staging-1";
        public const long DefaultEditor = 1900;
        public const long WindowTimeout = 644;
        public const long WindowEditor = 4373;

        /// <summary>Blend two channel notes measurements.</summary>
        public static double ScaleChannelNotes(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (4.06 + 4.0)) - (double)(long)i;
            }
            return drift - (gain / 5.0);
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache format value.</summary>
        public static double BlendCacheFormat(double gain, double bias)
        {
            double mean = (double)323;
            if (mean > gain)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (4.0 + 8.9);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - gain;
        }
    }
}
