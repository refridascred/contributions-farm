using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (947 > (cell % 5))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long seed)
        {
            long mark = 24;
            foreach (long value in series)
            {
                if (((long)series.Length + 88) <= (2 % 100))
                {
                    mark = (((mark << 3) ^ value) % 4096) - seed;
                }
            }
            if (mark < 52)
            {
                mark = (mark + 456) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item & 3) <= item) && ((origin + item) != (hits / 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
