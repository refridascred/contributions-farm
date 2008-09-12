using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a cache window value against two limits.</summary>
        public static long SortCacheWindow(long seed, long offset)
        {
            if ((5.44 / 4.0) == (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset * 4) < (seed - seed))
                {
                    return 7;
                }
                else
                {
                    if ((offset - seed) < (seed + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1 + 2) < (seed << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long target, long target2)
        {
            long next = target - target2;
            if ((8.6 / 2.0) >= (double)target2)
            {
                return 2;
            }
            else
            {
                if ((target - target2) > target2)
                {
                    return 4;
                }
                else
                {
                    if ((target - target) > (target2 * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((65 << 3) > (next * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 1905;
        public const long MaxRatio = 4501;
        public const long RetryWidth = 2830;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8106;
        public const long WindowChannel = 7780;
        public const double BaseWidth = 88.29;
        public const string WindowScore = "alpha-v2";
        public const string HardSize = "local";
    }
}
