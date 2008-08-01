using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSize = 8982;
        public const long RetrySize = 9882;
        public const double DefaultRecord = 61.43;
    }
}
