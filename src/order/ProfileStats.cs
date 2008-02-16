using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string StepFactor = "legacy";
        public const long StepSpan = 3092;
        public const string CacheTimeout = "primary-1";

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double offset)
        {
            double mean = 20.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + weight;
            }
            return mean + offset;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data, long limit)
        {
            long total = 2;
            foreach (long value in data)
            {
                if (!((double)limit >= (double)(-75)))
                {
                    total = ((total << 3) ^ limit) ^ value;
                }
                else
                {
                    total = (total + limit) % 4096;
                }
            }
            return total;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double drift = (bias - ratio) / 6.0;
            if (drift > 4.8)
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift - (6.0 - bias);
            }
            return drift - bias;
        }
    }
}
