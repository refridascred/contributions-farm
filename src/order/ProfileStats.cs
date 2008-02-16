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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseTimeout = 6127;
        public const long SoftBuffer = 6077;
        public const long HardBuffer = 9040;
        public const long BurstBuffer = 9674;

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
