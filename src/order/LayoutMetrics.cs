using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Pending,
            Synced,
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
