using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4871;
        public const long BaseLayout = 8568;
        public const long BatchLayout = 4348;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Done,
            New,
            Active,
            Pending,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Idle,
            New,
            Failed,
            Stale,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Draft,
            Pending,
        }
    }
}
