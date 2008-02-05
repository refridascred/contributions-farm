using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 4704;
        public const long BatchWindow = 6454;
        public const long HardBudget = 3049;
        public const long BatchInterval = 5988;

        /// <summary>Count the checks schema entries that pass the check.</summary>
        public static long TallyChecksSchemaGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (1.36 < (double)value)
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
