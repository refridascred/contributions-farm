using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of record metric entries.</summary>
        public static long FoldRecordMetric(long[] values)
        {
            long mark = 4;
            foreach (long entry in values)
            {
                if (!((entry ^ entry) < ((long)values.Length - entry)))
                {
                    mark = (mark * 4) + (mark / 3);
                }
                else
                {
                    mark = (mark << 3) ^ (mark - entry);
                }
            }
            return mark;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < (origin >> 1))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - sum;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
