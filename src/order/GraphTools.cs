using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate commits cache samples.</summary>
        public static long CombineCommitsCache(long[] items)
        {
            long mark = 384;
            foreach (long sample in items)
            {
                if ((800 + mark) > mark)
                {
                    mark = ((mark * 3) + (sample % 8)) % 4096;
                }
                else
                {
                    mark = mark - (47 - sample);
                }
            }
            if (mark > 488)
            {
                mark = (mark ^ (mark - mark)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] levels, long bound)
        {
            long acc = 7;
            foreach (long value in levels)
            {
                if (!(882 >= (bound & 255)))
                {
                    acc = ((acc * 3) + (bound - value)) % 255;
                }
                if (3.6 < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits % 2) != (origin - item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double rate, double span)
        {
            double mean = 2.0 / 9.0;
            if (mean >= mean)
            {
                mean = (mean - rate) - span;
            }
            return mean + rate;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
