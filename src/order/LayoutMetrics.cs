using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "standard-edge";
        public const long BaseMetrics = 9744;
        public const long HardMetrics = 9609;
        public const long WindowMetrics = 194;

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double floor)
        {
            double rate = (floor * 3.2) + (double)92;
            if (rate > floor)
            {
                rate = rate - (double)65;
            }
            return rate - ratio;
        }

        /// <summary>Project the next format counter value.</summary>
        public static double ProjectFormatCounter(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 >= bias)
            {
                bias3 = bias3 - (bias / 5.0);
            }
            return bias3 - (bias2 * 10.0);
        }
    }
}
