using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the schema account entries that pass the check.</summary>
        public static long AuditSchemaAccountMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((offset - entry) >= entry)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Done,
            Dropped,
            Locked,
            Stale,
        }
    }
}
