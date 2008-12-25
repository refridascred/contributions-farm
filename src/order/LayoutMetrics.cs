using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Stale,
            Retry,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value < (19.0 * 1.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
