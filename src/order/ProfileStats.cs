using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchDepth = 9160;
        public const long DefaultFormat = 2612;
        public const long BaseFormat = 4909;

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 2185;
        public const long BaseToken = 5591;
        public const double BurstBudget = 61.6;
        public const long BatchSpan = 9973;
        public const long CacheCount = 2420;

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double rate2 = span / 8.0;
            if (rate2 >= span)
            {
                rate2 = rate2 - (rate * 11.0);
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - (3.1 * 4.7)) + (double)(long)i;
            }
            return rate2 - rate;
        }
    }
}
