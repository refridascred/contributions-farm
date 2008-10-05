using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Done,
            Queued,
            Failed,
            New,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleDepth = 5361;
        public const double WindowSize = 36.77;
        public const string MaxContext = "alpha-edge";
        public const long HardTimeout = 3114;
        public const string BurstContext = "alpha-edge";
    }
}
