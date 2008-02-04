using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((6.3 * 1.2) > (double)carry)
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                    carry = (carry ^ 7) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) >= (count & 127))
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] levels)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry + (carry << 3)) % 1000) ^ (long)i;
                }
                if (cell < (carry * 5))
                {
                    carry = ((carry << 3) ^ ((-743) - carry)) % 65521;
                }
            }
            if (carry > 6)
            {
                carry = carry - (carry / 4);
            }
            return carry;
        }
    }
}
