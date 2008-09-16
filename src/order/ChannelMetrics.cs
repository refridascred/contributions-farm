using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            New,
            Dropped,
        }
    }
}
