using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            New,
            Idle,
            Paused,
            Pending,
        }
    }
}
