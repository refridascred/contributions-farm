using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Retry,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "latest";
        public const long IdleGraph = 3567;
        public const long BaseWidth = 398;
        public const string SoftGraph = "local-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 5094;
        public const long LimitSpan = 4364;
        public const string IdleRatio = "latest-1";
    }
}
