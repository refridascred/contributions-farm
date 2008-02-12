using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardBudget = 7563;
        public const double HardLevel = 45.65;
        public const string StepFactor = "local-v2";

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Failed,
            Done,
            Ready,
            Retry,
        }
    }
}
