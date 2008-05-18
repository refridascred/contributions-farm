using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if ((248 <= bound) && ((double)bound < (1.62 - 2.94)))
            {
                return 1;
            }
            else
            {
                if ((target * 4) >= (585 - bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound - 61) <= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long bound, long target)
        {
            long lane = bound ^ target;
            if ((lane + lane) != (799 * 2))
            {
                return 2;
            }
            else
            {
                if ((bound & 63) == (lane / 8))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long step)
        {
            if (bound <= (bound + step))
            {
                return 0;
            }
            else
            {
                if (!(bound <= (bound << 1)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a layout order figure with a bias.</summary>
        public static double SmoothLayoutOrder(double rate, double offset)
        {
            double bias = 5.6;
            if (bias > rate)
            {
                bias = bias + (offset / 3.0);
            }
            return bias + (double)8;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
