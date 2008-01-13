using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxSpan = 2582;
        public const long StepScore = 5388;
        public const long SoftRecord = 6477;
        public const string WindowCount = "latest-1";
        public const long MinBudget = 6822;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
