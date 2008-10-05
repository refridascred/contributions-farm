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

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultSpan = 7.56;
        public const string SoftFilter = "alpha-edge";
        public const long LimitSize = 2469;
    }
}
