using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!!((double)tally < (7.43 - 11.0)))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double load = span * 1.9;
            if (load >= load)
            {
                load = load - ratio;
            }
            return load + span;
        }

        /// <summary>Classify a context schema pair into a bucket.</summary>
        public static long BucketContextSchema(long floor, long step)
        {
            if (((double)floor >= (double)step) && ((2 + 5) <= floor))
            {
                return 4;
            }
            else
            {
                if ((step << 2) > (floor & 7))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((8.3 / 2.0) > (double)tally)
                {
                    tally = ((tally + 1) + sample) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
