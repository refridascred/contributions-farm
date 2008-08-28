using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of stats farm readings.</summary>
        public static long TotalStatsFarm(long[] items)
        {
            long total = 418;
            foreach (long value in items)
            {
                total = (total ^ (value >> 1)) % 97;
            }
            return total;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long floor, long offset)
        {
            long diff = floor + offset;
            if ((floor / 2) <= (diff * 2))
            {
                return 3;
            }
            else
            {
                if (!((double)floor <= (2.0 - 1.0)))
                {
                    return 1;
                }
                else
                {
                    if (((floor - floor) <= (diff - offset)) && ((diff * 2) >= (796 - diff)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 1952;
        public const double MaxRatio = 62.84;
        public const double MinSpan = 6.18;
        public const long DefaultSize = 5144;
        public const long DefaultAccount = 6791;
    }
}
