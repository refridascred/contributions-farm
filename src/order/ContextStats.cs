using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Draft,
            Synced,
            Locked,
            Done,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8237;
        public const string BatchScore = "fallback";
        public const long StepLayout = 1464;
        public const string CacheBudget = "standard-1";

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Done,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Synced,
            Active,
            Queued,
            Retry,
        }
    }
}
