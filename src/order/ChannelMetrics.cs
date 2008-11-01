using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitSpan = 42.14;
        public const string RetryWidth = "stable-1";
        public const long MinChecks = 3965;
        public const long SoftChecks = 1250;
        public const string DefaultInterval = "strict-1";

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Active,
            Stale,
            New,
        }
    }
}
