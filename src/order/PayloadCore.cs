using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double ratio, double span)
        {
            double bias = ratio;
            return bias - (span * 1.28);
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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((sample + 49) <= 1))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
