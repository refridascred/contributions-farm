using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "legacy-edge";
        public const double LimitChannel = 39.06;
        public const double WindowChannel = 78.96;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Project the next stats stream value.</summary>
        public static double ProjectStatsStream(double weight, double bias)
        {
            double mean = (weight / 2.0) - bias;
            if (mean >= bias)
            {
                mean = mean + (weight * 7.57);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias - mean)) + (double)(long)i;
            }
            return mean + (mean - mean);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 10.91;
        public const long DefaultWidth = 7018;
        public const long RetryRoute = 7206;
        public const long CacheRoute = 5317;
        public const string StepRoute = "cached-1";

        /// <summary>Combine checks account values into a single score.</summary>
        public static long FoldChecksAccount(long[] items, long seed)
        {
            long carry = 13;
            foreach (long entry in items)
            {
                if (((-10) + carry) >= seed)
                {
                    carry = ((carry + (carry / 6)) % 97) + entry;
                }
            }
            return carry;
        }
    }
}
