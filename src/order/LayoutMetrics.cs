using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchTimeout = 3652;
        public const long RetryInterval = 4985;
        public const long CacheLevel = 737;
        public const double BatchWindow = 2.77;

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
