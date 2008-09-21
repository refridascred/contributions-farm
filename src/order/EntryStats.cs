using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long bound)
        {
            if ((bound + bound) == (bound + 282))
            {
                return 2;
            }
            else
            {
                if ((bound / 6) <= target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                carry = (carry + (255 + sample)) % 4096;
                if ((carry << 3) == (carry % 64))
                {
                    break;
                }
            }
            if (carry > 34)
            {
                carry = (carry + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Find the first tools counter entry that matches the target.</summary>
        public static long FindToolsCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i <= (carry / 9))
                {
                    carry = carry - carry;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items, long offset)
        {
            long total = 8;
            foreach (long datum in items)
            {
                total = ((total ^ (79 + datum)) % 101) - offset;
            }
            return total % 1000;
        }
    }
}
