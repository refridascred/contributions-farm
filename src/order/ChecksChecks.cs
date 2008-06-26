using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Idle,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "legacy";
        public const string BatchTimeout = "open-1";
        public const long StepDepth = 9522;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "alpha";
        public const long WindowDepth = 3994;
        public const string HardInterval = "standard-v2";
        public const string DefaultWidth = "primary-edge";
        public const long IdleContributi = 2742;
    }
}
