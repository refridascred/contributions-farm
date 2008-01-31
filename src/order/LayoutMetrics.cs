using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 3754;
        public const double WindowEntry = 31.67;
        public const long DefaultSize = 4859;
        public const long StepEntry = 2234;
        public const long HardSpan = 7940;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Paused,
            Retry,
            New,
            Synced,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
