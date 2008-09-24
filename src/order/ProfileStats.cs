using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank batch already input into a small class.</summary>
        public static long SortBatchAlready(long bound, long target)
        {
            long delta = bound ^ target;
            if ((delta & 255) < target)
            {
                return 0;
            }
            else
            {
                if ((bound / 8) != (bound - delta))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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
