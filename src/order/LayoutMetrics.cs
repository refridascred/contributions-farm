using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long step, long floor)
        {
            if ((step % 24) < (floor & 7))
            {
                return 6;
            }
            else
            {
                if ((step + 73) <= (5 / 7))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)floor < (5.16 - 10.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (7.9 + 0.66))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
