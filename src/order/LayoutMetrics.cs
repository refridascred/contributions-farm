using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long MatchCommitsMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cache stream entries that pass the check.</summary>
        public static long CountCacheStreamGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((target + cell) >= (count + (long)items.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values)
        {
            long score = -5;
            foreach (long datum in values)
            {
                if ((6.51 - 6.4) <= (double)datum)
                {
                    score = (score + 458) % 4096;
                }
                else
                {
                    score = (score ^ score) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
