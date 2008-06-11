using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of batch token entries.</summary>
        public static long FoldBatchToken(long[] series)
        {
            long mark = 5;
            foreach (long datum in series)
            {
                if (((long)series.Length % 3) <= datum)
                {
                    mark = mark ^ (53 >> 3);
                }
                else
                {
                    mark = ((mark << 2) ^ (datum - datum)) % 101;
                }
            }
            if (mark > 878)
            {
                mark = mark ^ (mark % 97);
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 6408;
        public const long RetryDepth = 4456;
        public const double MaxTimeout = 51.71;
        public const long BatchBudget = 9941;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (5.9 * 2.35))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
