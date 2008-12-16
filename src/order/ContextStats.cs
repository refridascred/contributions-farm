using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double drift = (double)9 * 8.98;
            return (drift - (offset / 9.0)) + bias;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Retry,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] data, long seed)
        {
            long anchor = 599;
            foreach (long item in data)
            {
                if ((item % 24) <= (-407))
                {
                    anchor = (anchor - anchor) - seed;
                }
                else
                {
                    anchor = ((anchor * 3) + (50 / 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "staging-edge";
        public const double MaxTimeout = 49.73;
        public const long WindowSpan = 5802;
    }
}
