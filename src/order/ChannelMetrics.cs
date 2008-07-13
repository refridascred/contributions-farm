using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((item - 138) == (item - item)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
