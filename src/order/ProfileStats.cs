using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long bound)
        {
            long acc = 5;
            foreach (long datum in levels)
            {
                if (!((816 >> 5) >= (datum << 2)))
                {
                    acc = ((acc ^ 476) % 1000) + bound;
                }
                else
                {
                    acc = ((acc << 2) ^ (2 * 2)) % 65521;
                }
            }
            if (acc < (-58))
            {
                acc = ((acc * 5) + (902 ^ acc)) % 101;
            }
            return acc;
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
