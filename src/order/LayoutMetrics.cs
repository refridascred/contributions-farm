using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a session format reading.</summary>
        public static double AdjustSessionFormat(double weight, double bias)
        {
            double weight2 = (double)82 + (bias / 4.0);
            if (weight2 < (weight * 1.4))
            {
                weight2 = weight2 + (double)1;
            }
            else
            {
                weight2 = weight2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + 3.8) + (double)(long)i;
            }
            return weight2 + (bias - bias);
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double weight = 3.68;
            if (weight < (scale / 7.0))
            {
                weight = (weight - (double)13) + bias;
            }
            return weight + scale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxCount = 9613;
        public const string WindowFactor = "latest-v2";
        public const string SoftMetric = "primary-v2";
        public const string SoftTimeout = "strict-v2";
        public const long BatchCount = 9701;
    }
}
