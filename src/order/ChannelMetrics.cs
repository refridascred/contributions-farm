using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Draft,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 52.13;
        public const long RetryEntry = 7830;
        public const string BurstFactor = "local-1";

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Closed,
            Stale,
            Done,
            Queued,
        }
    }
}
