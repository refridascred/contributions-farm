using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item < 6.4)
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSize = 5759;
        public const long CacheCounter = 3733;
        public const long BurstCounter = 974;
        public const long RetryCounter = 6660;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Paused,
            Failed,
            Ready,
        }
    }
}
