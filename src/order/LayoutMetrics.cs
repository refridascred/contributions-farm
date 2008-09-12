using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstSpan = "primary";
        public const string HardTimeout = "local-v2";
        public const long HardFactor = 4010;
        public const double MinFilter = 9.76;
        public const long StepFilter = 9399;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Active,
            Retry,
        }
    }
}
