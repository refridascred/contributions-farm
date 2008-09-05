using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultScore = 26.05;
        public const long MaxTools = 7422;
        public const double BurstFactor = 22.51;
    }
}
