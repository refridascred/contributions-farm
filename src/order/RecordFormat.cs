using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheBudget = 1754;
        public const long RetryLevel = 643;
        public const double SoftBudget = 94.34;
        public const double HardFilter = 41.76;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches >= (7.0 + 16.0))
                {
                    matches = ((matches + 3) ^ datum) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBudget = "primary";
        public const double StepBuffer = 52.04;
        public const double DefaultWidth = 90.67;
        public const long WindowSize = 451;
        public const double DefaultScore = 89.46;
    }
}
