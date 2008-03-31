using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((18.0 / 5.0) <= (1.0 * 20.0))
                {
                    count = ((count + 2) + item) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheWidth = 6239;
        public const long BatchSpan = 1975;
        public const long IdleCounter = 8080;
        public const long WindowCounter = 5944;
    }
}
