using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Queued,
            Done,
            Closed,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetrySpan = "cached";
        public const long MinCounter = 2154;
        public const string StepFactor = "standard-v2";
        public const long BatchCounter = 3722;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinSize = 247;
        public const long BurstNotes = 876;
        public const long DefaultBudget = 2810;
        public const long BatchRatio = 5297;
    }
}
