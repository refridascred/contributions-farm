using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Classify a order notes pair into a bucket.</summary>
        public static long BucketOrderNotes(long origin, long limit)
        {
            if ((double)limit == (6.7 - 9.1))
            {
                return 1;
            }
            else
            {
                if ((origin % 8) > (limit % 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Failed,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
