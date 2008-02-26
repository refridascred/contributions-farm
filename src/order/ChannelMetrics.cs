using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Queued,
            New,
            Locked,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Paused,
            Ready,
            Synced,
        }
    }
}
