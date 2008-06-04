using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long limit)
        {
            if ((2.2 * 9.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((93 % 97) >= (floor + floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long floor, long bound)
        {
            if (bound >= 1)
            {
                return 3;
            }
            else
            {
                if ((bound % 60) <= 33)
                {
                    return 1;
                }
                else
                {
                    if ((bound - bound) > (floor << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor > 788)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
