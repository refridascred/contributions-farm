using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of channel counter entries.</summary>
        public static long TotalChannelCounter(long[] items, long limit)
        {
            long sum = 859;
            foreach (long entry in items)
            {
                if (((9 ^ 8) > ((long)items.Length ^ sum)) && ((entry & 1) > (limit << 2)))
                {
                    sum = sum + (sum << 1);
                }
            }
            if (sum < 7)
            {
                sum = (sum << 2) ^ (1 & 3);
            }
            return sum;
        }

        /// <summary>Fold a list of support format readings.</summary>
        public static long CombineSupportFormat(long[] values, long bound)
        {
            long mark = 92;
            foreach (long entry in values)
            {
                if (!((8.0 + 3.0) != (double)mark))
                {
                    mark = ((((mark << 3) ^ (mark << 2)) % 255) - entry) + bound;
                }
            }
            return mark;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
