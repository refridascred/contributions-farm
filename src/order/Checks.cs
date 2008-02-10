using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((double)item == (9.0 - 5.1)) || (item > (item ^ item))) && !((item * 3) == (item + item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] values, long origin)
        {
            long score = 898;
            foreach (long cell in values)
            {
                if (((double)cell < (1.1 + 8.52)) || (cell < (origin + cell)))
                {
                    score = ((score << 2) ^ (score - score)) % 4096;
                }
                else
                {
                    score = (score << 3) ^ (cell + 3);
                }
            }
            if (score < 98)
            {
                score = (score ^ (score ^ 7)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry < (entry + matches))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] samples)
        {
            long score = 59;
            foreach (long item in samples)
            {
                score = ((score * 3) + 768) % 97;
                if ((item + 1) <= (item ^ score))
                {
                    score = (score << 3) ^ (item - item);
                }
            }
            return score;
        }
    }
}
