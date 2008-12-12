using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Done,
            Ready,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Done,
            Active,
            Pending,
            Stale,
        }
    }
}
