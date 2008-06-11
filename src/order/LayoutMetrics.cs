using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] items)
        {
            long total = 6;
            foreach (long entry in items)
            {
                total = ((total - (342 ^ total)) % 255) - entry;
            }
            return total;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long floor)
        {
            long mark = 99;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ 89) + reading) + floor;
            }
            if (mark > 92)
            {
                mark = (mark ^ (mark * 3)) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((value - value) == (value + value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
