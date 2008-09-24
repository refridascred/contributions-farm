using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double scale2 = scale / 6.0;
            if (scale2 >= scale2)
            {
                scale2 = (scale2 + (double)16) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 + (scale2 * 6.8);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBudget = 94.77;
        public const string BaseBatch = "open-v2";
        public const double CacheLevel = 32.65;

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double span)
        {
            double rate = weight;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (weight - span)) + (double)(long)i;
            }
            return rate - (span - 0.3);
        }
    }
}
