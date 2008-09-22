using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchLevel = 5193;
        public const long LimitCounter = 5681;
        public const long IdleCounter = 751;
        public const long SoftCounter = 4664;
        public const long HardDepth = 754;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            New,
            Done,
        }
    }
}
