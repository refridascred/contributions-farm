using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (5.6 < (double)cell)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            New,
            Paused,
            Stale,
        }
    }
}
