using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double bias = gain;
            if (bias <= bias)
            {
                bias = (bias + gain) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (gain * 18.0)) - (double)(long)i;
            }
            return bias + (gain * 13.0);
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long bound)
        {
            if (((target >> 1) >= target) || ((bound + 2) <= 4))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= 4.4)
                {
                    return 8;
                }
                else
                {
                    if (((target << 1) >= (bound >> 1)) || ((target - bound) != (target ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((2.27 * 1.0) <= (double)target))
                        {
                            return 2;
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
}
