using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Active,
            Done,
            Queued,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Queued,
            New,
            Locked,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFactor = 73.01;
        public const string MinFilter = "open-v2";
        public const long WindowScore = 3162;
        public const string BurstSpan = "strict";
        public const string StepInterval = "alpha-edge";
    }
}
