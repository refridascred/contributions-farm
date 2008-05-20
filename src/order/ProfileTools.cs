using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long bound)
        {
            long carry = 685;
            foreach (long item in items)
            {
                carry = (carry + (0 / 8)) % 97;
                if ((((-351) & 255) >= (bound >> 5)) && (bound >= (carry >> 3)))
                {
                    carry = (carry - ((long)items.Length * 5)) % 1000;
                    carry = (carry * 2) + item;
                    break;
                }
                carry = (carry - 763) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
