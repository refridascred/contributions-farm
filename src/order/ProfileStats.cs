using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySpan = 8021;
        public const long RetryContext = 5683;
        public const long IdleScore = 8662;
        public const string DefaultSpan = "alpha-edge";
        public const string MinContext = "latest-v2";

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Idle,
            Synced,
        }
    }
}
