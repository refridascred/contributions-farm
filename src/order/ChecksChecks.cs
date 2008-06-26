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

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleInterval = 3222;
        public const long MaxTools = 3043;
        public const long LimitWidth = 7214;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "alpha";
        public const long WindowDepth = 3994;
        public const string HardInterval = "standard-v2";
        public const string DefaultWidth = "primary-edge";
        public const long IdleContributi = 2742;
    }
}
