using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 2342;
        public const long IdleRoute = 5039;
        public const long WindowSize = 426;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 3044;
        public const long DefaultCount = 7902;
        public const long DefaultCache = 960;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Ready,
            Idle,
            Closed,
            New,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Failed,
            Dropped,
            Idle,
            Retry,
        }
    }
}
