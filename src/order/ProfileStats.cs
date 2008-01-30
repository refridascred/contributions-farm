using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            New,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = mark - (seed >> 4);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long result = -73;
            foreach (long value in items)
            {
                result = (result ^ (982 + (-4))) - value;
            }
            return result;
        }
    }
}
