using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Done,
            Active,
            Failed,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Draft,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 8215;
        public const long IdleDepth = 2183;
        public const long StepDepth = 5351;
        public const long CacheDepth = 9119;
    }
}
