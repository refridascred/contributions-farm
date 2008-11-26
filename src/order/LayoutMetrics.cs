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

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double gain = scale;
            if (gain > (double)67)
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain + scale)) - (double)(long)i;
            }
            return gain - (5.0 * 9.27);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 6198;
        public const long WindowStream = 7170;
        public const double MinTimeout = 72.28;
    }
}
