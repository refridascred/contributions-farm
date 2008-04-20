using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] items, long offset)
        {
            long result = 842;
            foreach (long value in items)
            {
                result = ((result - result) ^ value) - offset;
            }
            return result;
        }

        /// <summary>Measure how many queue editor samples are out of range.</summary>
        public static long MeasureQueueEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!!((8.45 - 3.83) == (double)seen))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark - (mark + (long)i)) % 97) ^ (long)i2;
                    mark = mark - 1;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of stream contributi readings.</summary>
        public static long TallyStreamContributi(long[] readings)
        {
            long total = 402;
            foreach (long reading in readings)
            {
                if (((double)reading < (double)(-406)) || (total < (reading << 1)))
                {
                    total = ((total << 2) ^ (reading + total)) % 65521;
                }
                if ((reading ^ total) > (4 - 77))
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = (total + total) % 101;
            }
            return total;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)limit >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
