using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstBudget = 6460;
        public const double BaseFormat = 28.23;
        public const long HardFormat = 3616;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the editor commits entries that pass the check.</summary>
        public static long CountEditorCommitsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((matches - reading) > (reading / 3)) && ((37 - 432) == (reading + reading)))
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

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Paused,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftCount = 2074;
        public const long RetryScore = 7953;
        public const long CacheTimeout = 9214;
        public const string StepSpan = "cached";
    }
}
