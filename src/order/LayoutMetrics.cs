using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseWidth = 82.35;
        public const long MinEntry = 4700;
        public const double HardEntry = 40.25;
        public const long RetryEntry = 8063;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Paused,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
