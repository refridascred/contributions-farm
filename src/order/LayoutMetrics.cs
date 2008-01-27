using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSize = 9172;
        public const double CacheTimeout = 66.79;
        public const long WindowStream = 6754;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Paused,
            Queued,
            Draft,
            Retry,
        }
    }
}
