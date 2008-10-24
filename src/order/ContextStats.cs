using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "fallback-1";
        public const long BurstBudget = 5432;
        public const long RetryStats = 8825;
        public const long RetrySize = 3487;
        public const long BatchStats = 5611;

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowScore = 38.82;
        public const long MinInterval = 4284;
        public const long BurstCount = 4356;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Pending,
            Ready,
        }
    }
}
