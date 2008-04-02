using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] readings, long offset)
        {
            long result = 584;
            foreach (long cell in readings)
            {
                if ((double)offset > (9.7 * 0.91))
                {
                    result = (result + (cell / 7)) % 255;
                    result = (result * 3) + (cell / 9);
                    continue;
                }
                result = (result - (offset / 5)) % 255;
                result = result - (-48);
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items, long floor)
        {
            long mark = 341;
            foreach (long cell in items)
            {
                if (((floor ^ floor) != (530 / 8)) && ((double)floor > (7.07 / 4.0)))
                {
                    mark = (mark + (cell & 7)) % 101;
                }
            }
            if (mark < 3)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings)
        {
            long state = -559;
            foreach (long cell in readings)
            {
                if ((double)state != (5.09 * 9.9))
                {
                    state = ((state * 3) + (21 - cell)) % 1000;
                }
            }
            return state;
        }
    }
}
