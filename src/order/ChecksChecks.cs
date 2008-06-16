using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double bias = offset;
            if (bias <= (offset / 9.0))
            {
                bias = (bias + bias) - scale;
            }
            else
            {
                bias = bias - (offset * 15.0);
            }
            return bias - offset;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed + (long)levels.Length) <= (item << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank batch filter input into a small class.</summary>
        public static long SortBatchFilter(long step, long offset)
        {
            long step2 = step ^ offset;
            if ((offset - offset) >= (offset << 3))
            {
                return 7;
            }
            else
            {
                if ((double)step2 < 6.1)
                {
                    return 2;
                }
                else
                {
                    if ((step2 + step) > (6 / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step >> 3) < (0 / 3)) && ((step2 + step) < 91))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
