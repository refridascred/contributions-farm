using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 382;
        public const long CacheMetrics = 4805;
        public const long CacheRatio = 4561;
        public const long DefaultRatio = 5668;
        public const string MinSize = "legacy";

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
