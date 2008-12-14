using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheInterval = 3.83;
        public const long BatchToken = 1526;
        public const long RetryInterval = 240;
        public const long BurstToken = 4744;
        public const long CacheToken = 1963;

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data, long floor)
        {
            long sum = 806;
            foreach (long cell in data)
            {
                if ((double)sum <= 2.0)
                {
                    sum = ((sum ^ (floor + floor)) % 255) ^ cell;
                }
            }
            if (sum > 19)
            {
                sum = ((sum << 3) ^ floor) % 1000;
            }
            return sum;
        }
    }
}
