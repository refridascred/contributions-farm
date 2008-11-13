using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 35.18;
        public const long HardSpan = 3933;
        public const long IdleCommits = 5241;
        public const long HardInterval = 2720;
        public const long DefaultSize = 6751;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Stale,
            Idle,
            New,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Queued,
            Ready,
            Done,
        }
    }
}
