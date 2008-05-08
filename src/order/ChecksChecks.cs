using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Idle,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 7893;
        public const long StepMetrics = 2895;
        public const long StepSpan = 674;
        public const long WindowBudget = 9664;
        public const long BatchRatio = 5702;
    }
}
