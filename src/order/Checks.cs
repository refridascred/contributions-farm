using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Idle,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Audit session support readings against a rule.</summary>
        public static long AuditSessionSupportHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((51 - count) == ((-89) - count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
