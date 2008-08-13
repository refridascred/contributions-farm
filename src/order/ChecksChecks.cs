using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 4696;
        public const string IdleFormat = "latest-edge";
        public const double RetryBudget = 65.89;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const string StepSize = "staging-v2";
        public const long LimitBudget = 1419;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
