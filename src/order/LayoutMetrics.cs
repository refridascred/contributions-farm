using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxBudget = 7644;
        public const long CacheDepth = 1556;
        public const string MaxGraph = "stable-edge";
        public const string WindowInterval = "stable";
        public const long WindowGraph = 461;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
