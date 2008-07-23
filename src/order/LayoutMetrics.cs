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

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
