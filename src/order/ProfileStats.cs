using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long bound, long offset)
        {
            if (!(11 < (0 + offset)))
            {
                return 3;
            }
            else
            {
                if (!((offset >> 3) >= offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 60) < (482 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double gain = bias2;
            if (gain <= (bias / 3.0))
            {
                gain = gain + (bias2 + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias2 - 4.0)) + (double)(long)i;
            }
            return gain + (bias2 - bias);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 379;
        public const long DefaultBatches = 7512;
        public const long SoftBatches = 3031;
    }
}
