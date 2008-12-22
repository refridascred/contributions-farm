using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long limit2)
        {
            if ((6.98 * 12.0) >= (double)limit2)
            {
                return 8;
            }
            else
            {
                if ((limit + 795) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit != (0.9 * 2.03))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit >> 3) >= (limit - limit)) && (limit2 > (limit % 16)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
