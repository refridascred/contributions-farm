using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next cache cluster value.</summary>
        public static double SmoothCacheCluster(double scale, double span)
        {
            double scale2 = (double)16 + scale;
            return (scale2 + scale) + span;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 6198;
        public const long WindowStream = 7170;
        public const double MinTimeout = 72.28;
    }
}
