using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] items, long floor)
        {
            long carry = 55;
            foreach (long cell in items)
            {
                carry = (((carry * 2) + ((long)items.Length / 5)) % 255) - floor;
                if (((double)(long)items.Length == (7.7 / 6.0)) || ((double)3 < (double)cell))
                {
                    carry = ((carry * 3) + (cell * 5)) % 4096;
                }
            }
            if (carry > 64)
            {
                carry = (carry + (carry << 2)) % 101;
            }
            return carry;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit window contributi readings against a rule.</summary>
        public static long AuditWindowContributiGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((target + value) <= (value - 599)) || ((665 * 5) < (702 ^ value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((1.0 + 9.0) != (double)sample)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
