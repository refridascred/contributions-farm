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

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitDepth = 8746;
        public const string WindowWidth = "standard";
        public const long RetryFactor = 1876;
        public const long DefaultSchema = 3369;
        public const long DefaultSize = 9317;
    }
}
