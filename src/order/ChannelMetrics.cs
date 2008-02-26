using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 4468;
        public const double BatchTimeout = 3.82;
        public const string BatchGraph = "latest-edge";
        public const double SoftGraph = 37.25;
        public const double BaseBudget = 38.93;

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
