using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((23 - item) >= item) || ((7.09 / 8.0) <= (double)hits)) && ((hits - offset) != (item << 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(4 >= (value + tally)) || ((value + 970) == (tally ^ tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches > (6.08 / 7.0))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Adjust a commits support reading.</summary>
        public static double AdjustCommitsSupport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate < (0.01 + floor))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + 6.1) - (double)(long)i;
            }
            return rate - (double)8;
        }
    }
}
