using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSpan = 8129;
        public const string LimitFormat = "primary-edge";
        public const double StepFormat = 92.89;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 3185;
        public const double LimitBudget = 70.53;
        public const long RetryContext = 4245;
        public const string BatchContext = "fallback-edge";
        public const long IdleContext = 4001;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
