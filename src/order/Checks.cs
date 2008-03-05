using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((offset - 299) <= (matches % 12)) && !((4 + item) < (matches % 16)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Failed,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowCount = "standard";
        public const long HardGraph = 6198;
        public const string MaxGraph = "legacy-edge";
        public const long HardBudget = 7170;
        public const double DefaultGraph = 58.62;
    }
}
