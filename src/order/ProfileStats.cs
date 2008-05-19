using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long bound, long step)
        {
            if (((0.2 * 2.6) <= (double)step) || ((step + 1) == (step ^ bound)))
            {
                return 2;
            }
            else
            {
                if ((step & 63) < (586 - bound))
                {
                    return 6;
                }
                else
                {
                    if ((7 / 3) >= (bound / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two tools filter measurements.</summary>
        public static double AdjustToolsFilter(double scale, double offset)
        {
            double ratio = (double)(6 ^ 53);
            return (ratio - scale) + offset;
        }
    }
}
