using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metric support value against two limits.</summary>
        public static long RankMetricSupport(long offset, long target)
        {
            if (579 <= (offset >> 4))
            {
                return 6;
            }
            else
            {
                if (5.0 <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((1.7 + 9.2) == (double)item) && ((77 % 8) != (item << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items)
        {
            long carry = 66;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ (datum * 2)) % 97;
                if (892 > carry)
                {
                    carry = (carry - (carry / 2)) % 97;
                }
            }
            return carry;
        }
    }
}
