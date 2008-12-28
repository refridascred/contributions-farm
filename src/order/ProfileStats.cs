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

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double bias)
        {
            double scale = bias - (rate + rate);
            if (scale <= 6.9)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + rate;
            }
            return scale - (double)(-13);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 66.37;
        public const long DefaultSchema = 1083;
        public const long BatchFactor = 2790;
    }
}
