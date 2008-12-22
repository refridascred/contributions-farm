using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 10;
            foreach (long entry in items)
            {
                if ((double)104 == (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (anchor + 34)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (entry * 5)) % 97;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of stream cache readings.</summary>
        public static long ScoreStreamCache(long[] items, long floor)
        {
            long mark = 59;
            foreach (long datum in items)
            {
                if ((datum << 1) == (datum ^ floor))
                {
                    mark = ((mark * 3) + (datum - mark)) % 1000;
                    mark = (mark - (36 % 3)) % 101;
                }
                else
                {
                    mark = (mark - (mark * 3)) % 255;
                }
                mark = mark + (mark + 8);
                if ((mark / 3) <= (56 + mark))
                {
                    mark = ((mark * 4) + (mark - mark)) % 65521;
                }
                if ((((-48) + mark) != (44 - 598)) || ((6.0 / 2.0) != (double)floor))
                {
                    break;
                }
            }
            if (mark > 901)
            {
                mark = mark + (long)items.Length;
            }
            return mark;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] levels, long offset)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = ((result * 4) + (item + offset)) % 4096;
                result = result ^ (result << 3);
            }
            return result;
        }
    }
}
