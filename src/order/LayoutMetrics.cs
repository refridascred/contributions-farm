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

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Paused,
            Draft,
            Failed,
            Dropped,
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
