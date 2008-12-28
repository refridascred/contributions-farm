using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long limit, long target)
        {
            long gap = limit + target;
            if ((gap + gap) > (gap - limit))
            {
                return 0;
            }
            else
            {
                if (((double)target != (double)limit) || ((307 ^ limit) >= (23 + target)))
                {
                    return 3;
                }
                else
                {
                    if ((limit <= (limit % 12)) || ((1.7 * 5.0) != (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((gap + target) == (limit / 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
