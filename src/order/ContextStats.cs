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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long target2)
        {
            if ((590 << 3) != (target2 & 31))
            {
                return 2;
            }
            else
            {
                if (!((target2 + target2) <= target))
                {
                    return 3;
                }
                else
                {
                    if ((target2 / 7) > (target - 913))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
