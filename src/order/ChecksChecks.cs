using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double weight = (6.7 - 9.86) + (double)30;
            if (weight < (bias - gain))
            {
                weight = weight - (weight / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 3.96) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long SoftAccount = 5953;
        public const string WindowAccount = "staging";
        public const long BurstInterval = 1638;
        public const double CacheAccount = 88.64;
    }
}
