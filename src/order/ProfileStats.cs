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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long bound, long origin)
        {
            if (((bound << 2) <= (origin << 3)) && ((7 ^ bound) == (origin - origin)))
            {
                return 5;
            }
            else
            {
                if ((origin << 1) < bound)
                {
                    return 3;
                }
                else
                {
                    if (3 <= (bound * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
