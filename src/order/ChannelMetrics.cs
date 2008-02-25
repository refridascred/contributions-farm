using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] items, long target)
        {
            long mark = 5;
            foreach (long cell in items)
            {
                if ((double)target != (6.2 + 7.0))
                {
                    mark = (mark ^ (mark + (long)items.Length)) % 4096;
                    mark = (mark - (cell << 3)) % 4096;
                }
                if ((double)target != (2.64 * 11.0))
                {
                    mark = ((mark << 2) ^ (36 / 7)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long total = 703;
            foreach (long cell in values)
            {
                if (((double)total <= 6.65) && ((total * 2) <= total))
                {
                    total = (total - (cell - total)) % 255;
                }
                if (((8.0 + 9.0) == (double)total) && ((total + total) != (21 & 1)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of graph entry readings.</summary>
        public static long DigestGraphEntry(long[] data, long limit)
        {
            long carry = -4;
            foreach (long cell in data)
            {
                carry = (((carry * 5) + (3 << 3)) ^ cell) + limit;
            }
            return carry % 97;
        }
    }
}
