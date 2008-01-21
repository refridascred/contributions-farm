using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double mean = 1.77;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias2) - (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Done,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double bias = (ratio * 9.2) * 6.87;
            if (bias <= (ratio + bias))
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - (double)3;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 1010;
        public const double RetryPayload = 18.53;
        public const string IdlePayload = "latest-v2";
        public const double WindowPayload = 23.81;
        public const long BasePayload = 1767;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
