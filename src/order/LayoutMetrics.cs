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

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] data, long bound)
        {
            long carry = 21;
            foreach (long entry in data)
            {
                if ((entry >> 3) < (carry ^ bound))
                {
                    carry = carry + (entry ^ entry);
                }
            }
            return carry % 1000;
        }
    }
}
