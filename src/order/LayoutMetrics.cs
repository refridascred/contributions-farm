using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 8385;
        public const double MinSpan = 16.42;
        public const long HardBudget = 487;

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double gain, double bias)
        {
            double mean = (4.6 * 2.91) / 5.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)(long)i) + bias;
            }
            return mean + gain;
        }
    }
}
