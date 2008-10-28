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

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryFactor = 89.21;
        public const long SoftBudget = 744;
        public const string StepFactor = "open-v2";
        public const long MaxToken = 222;
        public const string StepTimeout = "stable-1";

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Paused,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values)
        {
            long acc = 83;
            foreach (long reading in values)
            {
                acc = ((acc + (acc * 3)) % 1000) ^ reading;
            }
            if (acc > (-69))
            {
                acc = acc + (72 & 31);
            }
            return acc;
        }
    }
}
