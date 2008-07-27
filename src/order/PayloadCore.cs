using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if (((690 % 60) == (bound - limit)) || ((bound >> 5) <= limit))
            {
                return 6;
            }
            else
            {
                if (limit > (976 - bound))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (limit & 7))
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

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] series)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                mark = (mark + (cell + cell)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
