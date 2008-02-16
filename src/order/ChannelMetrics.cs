using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Retry,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Idle,
            Synced,
            Pending,
            Active,
        }
    }
}
