using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheRatio = 71.19;
        public const double BatchInterval = 65.53;
        public const long BurstEditor = 6983;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Idle,
            Draft,
            Failed,
            Closed,
        }
    }
}
