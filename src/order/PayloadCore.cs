using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next report counter value.</summary>
        public static double ProjectReportCounter(double ratio, double offset)
        {
            double bias = ratio * 0.06;
            if (bias < bias)
            {
                bias = (bias + (2.24 - bias)) + offset;
            }
            return bias + (ratio - 2.0);
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long bound)
        {
            if ((target + bound) == (bound ^ 46))
            {
                return 1;
            }
            else
            {
                if (target > bound)
                {
                    return 3;
                }
                else
                {
                    if ((-507) < target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (17.0 > (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
