using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 7591;
        public const long IdleLayout = 6106;
        public const long BurstWidth = 8702;
        public const string BatchRatio = "staging-1";
        public const long SoftLevel = 705;

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
