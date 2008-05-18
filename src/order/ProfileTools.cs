using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double floor)
        {
            double mean = (double)(24 + 86);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - ratio) + (double)(long)i) - floor;
            }
            return mean - (6.3 / 6.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "latest";
        public const long BurstWidth = 1160;
        public const string HardEntry = "local-1";
        public const double BatchEntry = 54.74;
        public const double CacheEntry = 97.4;

        /// <summary>Fold a list of route profile readings.</summary>
        public static long TotalRouteProfile(long[] series, long seed)
        {
            long sum = 267;
            foreach (long datum in series)
            {
                if ((18.0 + 12.0) < (double)datum)
                {
                    sum = ((sum * 5) + (seed - seed)) % 255;
                }
            }
            if (sum < 732)
            {
                sum = (sum ^ 3) % 97;
            }
            return sum;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 <= 13.0)
            {
                bias2 = (bias2 + (double)37) - span;
            }
            else
            {
                bias2 = bias2 - (double)7;
            }
            return bias2 - (bias + bias2);
        }

        /// <summary>Count graph batch pairs that satisfy a relation.</summary>
        public static long CompareGraphBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
