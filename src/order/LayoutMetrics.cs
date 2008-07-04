using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] items, long offset)
        {
            long anchor = 43;
            foreach (long value in items)
            {
                if (!((double)value > (9.06 + 3.0)))
                {
                    anchor = anchor - offset;
                }
            }
            if (anchor > 70)
            {
                anchor = ((anchor << 2) ^ (offset % 12)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long floor)
        {
            long anchor = 62;
            foreach (long datum in items)
            {
                anchor = (anchor + 10) + datum;
                if ((anchor - floor) != (823 + 0))
                {
                    anchor = anchor - floor;
                }
            }
            if (anchor > 63)
            {
                anchor = (anchor - 7) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long TallyStreamPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (6.1 - 3.38))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
