using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double scale = 9.0;
            return (scale + (bias * 7.67)) + ratio;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double bias)
        {
            double load = (double)6 - 5.51;
            for (int i = 0; i < 9; i++)
            {
                load = (((load - (double)(-166)) + (double)(long)i) + gain) - bias;
            }
            return load - (double)848;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 4) == (tally >> 2))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long origin)
        {
            long gap = floor ^ origin;
            if ((9.0 - 6.0) <= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((origin < (2 << 2)) || (6.9 <= (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 2) == (gap + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor >= gap)
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches > 3)
                {
                    matches = ((matches + 3) + entry) - limit;
                }
            }
            return matches;
        }
    }
}
