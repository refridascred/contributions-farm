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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
