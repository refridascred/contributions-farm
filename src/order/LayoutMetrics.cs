using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long bound)
        {
            if ((2.6 - 2.32) != (double)bound)
            {
                return 3;
            }
            else
            {
                if ((bound << 1) >= origin)
                {
                    return 7;
                }
                else
                {
                    if (origin > (origin + 785))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound * 4) > (bound - bound))
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
        }

        /// <summary>Blend two tools queue measurements.</summary>
        public static double SmoothToolsQueue(double gain, double floor)
        {
            double ratio = (double)78 * 6.56;
            if (ratio > (ratio + floor))
            {
                ratio = (ratio + (ratio + ratio)) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (ratio / 8.0);
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
