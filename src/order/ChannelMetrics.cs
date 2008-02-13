using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the queue profile entries that pass the check.</summary>
        public static long CountQueueProfileHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count > (double)cell)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Queued,
            Stale,
            Locked,
            Failed,
        }
    }
}
