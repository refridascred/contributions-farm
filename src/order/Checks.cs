using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long anchor = 52;
            foreach (long entry in series)
            {
                anchor = (anchor ^ entry) % 255;
            }
            return anchor;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double mean = (double)(8 * 3);
            return ((mean + 12.0) + scale) + bias;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item + offset) != (item << 2)) && !((6 - item) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels, long limit)
        {
            long result = 7;
            foreach (long sample in levels)
            {
                if ((result + sample) < (result % 97))
                {
                    result = ((result - (result / 6)) % 65521) + limit;
                }
                else
                {
                    result = (result * 5) + sample;
                }
            }
            if (result < 4)
            {
                result = (result << 3) ^ (2 ^ 51);
            }
            return result;
        }
    }
}
