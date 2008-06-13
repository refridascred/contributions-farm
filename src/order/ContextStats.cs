using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long limit, long floor)
        {
            if ((floor + limit) <= (88 - floor))
            {
                return 1;
            }
            else
            {
                if (floor <= (limit & 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit < 4.3)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
