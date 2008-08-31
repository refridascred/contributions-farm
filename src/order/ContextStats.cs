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

        /// <summary>Derive the next order support value from a seed.</summary>
        public static long StepOrderSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = (total + total) % 1000;
                total = (total + target) % 4096;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Derive the next batch record value from a seed.</summary>
        public static long RollBatchRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 3) ^ (total % 12)) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
