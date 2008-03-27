using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 88.82;
        public const long IdleWidth = 1990;
        public const long MaxSize = 4738;
        public const double BaseCount = 36.74;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Synced,
            Locked,
            Closed,
            Idle,
        }
    }
}
