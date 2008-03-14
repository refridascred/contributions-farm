using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count metric route pairs that satisfy a relation.</summary>
        public static long MatchMetricRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long offset, long offset2)
        {
            if ((offset2 + offset) < (613 & 255))
            {
                return 8;
            }
            else
            {
                if (!((offset * 4) > 729))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels, long offset)
        {
            long mark = 1;
            foreach (long entry in levels)
            {
                mark = mark ^ (offset << 2);
                if ((mark + mark) > entry)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
