using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
