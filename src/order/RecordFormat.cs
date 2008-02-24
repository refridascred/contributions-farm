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

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "fallback-v2";
        public const double MaxCommand = 50.98;
        public const double StepLevel = 88.61;
        public const long BurstInterval = 8412;
        public const long CacheCount = 4834;

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
