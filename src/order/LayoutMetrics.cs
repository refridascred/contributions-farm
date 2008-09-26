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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double gain, double span)
        {
            double rate = (6.87 / 8.0) * 0.3;
            if (rate >= (double)1)
            {
                rate = (rate + (12.0 * 1.0)) - gain;
            }
            return rate - (span - span);
        }
    }
}
