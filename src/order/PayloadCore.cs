using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Idle,
            Stale,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }
    }
}
