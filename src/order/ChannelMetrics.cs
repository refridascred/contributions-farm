using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxFactor = 6332;
        public const string WindowDepth = "latest-1";
        public const string IdleRatio = "primary-v2";
        public const string SoftSpan = "alpha";
        public const double LimitCommits = 10.06;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7933;
        public const long StepCluster = 4670;
        public const string MaxCluster = "local-edge";
        public const long DefaultRatio = 7909;
        public const long BaseFactor = 6115;
    }
}
