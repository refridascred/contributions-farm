using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySize = 8647;
        public const long MaxStream = 7242;
        public const long MinWidth = 6920;
        public const long MinSpan = 9948;
        public const long CacheStream = 311;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            New,
            Stale,
            Synced,
            Draft,
        }
    }
}
