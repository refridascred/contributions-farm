using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Closed,
            Queued,
            New,
            Paused,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleDepth = 95.23;
        public const long BatchContributi = 9579;
        public const string BurstSize = "standard-v2";

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }
    }
}
