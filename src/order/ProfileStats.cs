using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a account layout value against two limits.</summary>
        public static long ClassifyAccountLayout(long seed, long bound)
        {
            if ((bound + 9) < bound)
            {
                return 0;
            }
            else
            {
                if (407 < (seed % 8))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 6) >= (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double scale2 = (double)(655 * 3);
            if (scale2 <= scale)
            {
                scale2 = (scale2 + (double)(-163)) - bias;
            }
            return scale2 - (6.16 + scale2);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 66.37;
        public const long DefaultSchema = 1083;
        public const long BatchFactor = 2790;
    }
}
