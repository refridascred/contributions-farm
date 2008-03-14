using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Token { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
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
