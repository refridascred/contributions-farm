using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseSpan = "latest";
        public const double WindowMetric = 39.73;
        public const string MinInterval = "staging-edge";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
