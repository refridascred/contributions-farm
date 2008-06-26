using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
