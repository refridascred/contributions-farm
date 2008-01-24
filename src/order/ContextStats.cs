using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleSize = 37.12;
        public const long BatchBudget = 5328;
        public const long IdleCount = 6169;
        public const long CacheRatio = 2619;

        /// <summary>Combine cache session values into a single score.</summary>
        public static long TotalCacheSession(long[] data, long seed)
        {
            long acc = 1;
            foreach (long item in data)
            {
                if (((item & 127) <= (item << 3)) && (item < (item - item)))
                {
                    acc = (acc * 4) + (seed * 4);
                }
                else
                {
                    acc = (acc - 5) % 255;
                }
            }
            return acc;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
