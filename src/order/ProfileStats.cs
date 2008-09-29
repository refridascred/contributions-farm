using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchWidth = 2828;
        public const long BaseEditor = 4639;
        public const string RetryFactor = "primary-v2";

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Done,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 < (double)24)
            {
                bias2 = (bias2 - (double)3) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (7.0 / 9.0)) - (double)(long)i;
            }
            return bias2 - (double)(-3);
        }
    }
}
