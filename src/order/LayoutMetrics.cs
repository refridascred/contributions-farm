using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (state * 5);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < (ratio * 3.9))
            {
                mean = mean - mean;
            }
            return mean - floor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxInterval = 73.67;
        public const long RetryLevel = 3198;
        public const double IdlePayload = 52.77;
        public const double RetryBudget = 18.29;
    }
}
