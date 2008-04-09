using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Locked,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Failed,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }
    }
}
