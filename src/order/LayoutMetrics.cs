using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Draft,
            New,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultSpan = "legacy-1";
        public const long StepSize = 1066;
        public const long CacheGraph = 8978;
        public const long HardGraph = 2242;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Synced,
            Idle,
            Paused,
            Pending,
        }
    }
}
