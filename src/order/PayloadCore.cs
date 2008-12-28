using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Failed,
            Dropped,
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
