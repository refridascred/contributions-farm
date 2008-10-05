using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheWidth = 4232;
        public const string DefaultMetric = "local-v2";
        public const string WindowMetric = "strict-v2";
        public const double IdleMetric = 17.38;

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > (double)7)
            {
                gain = gain + offset;
            }
            return gain - (double)9;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double rate = scale;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + scale) + (double)(long)i) + bias;
            }
            return rate - (rate * 1.0);
        }
    }
}
