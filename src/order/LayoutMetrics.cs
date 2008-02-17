using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Ready,
            Failed,
            Pending,
            New,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 42.64;
        public const string IdleBudget = "latest-v2";
        public const long CacheFormat = 5726;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Locked,
        }
    }
}
