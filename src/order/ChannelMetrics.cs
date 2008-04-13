using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 6221;
        public const double BurstTimeout = 73.75;
        public const long WindowLevel = 8935;
        public const string MaxScore = "staging";

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
