using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 1849;
        public const long BaseMetric = 5599;
        public const long IdleBudget = 6399;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheTimeout = 2880;
        public const long BurstRatio = 923;
        public const string StepCluster = "latest-1";
        public const string BurstDepth = "staging-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3182;
        public const string MaxWidth = "standard-edge";
        public const long MaxBatches = 7954;
        public const long HardBatches = 2436;
        public const long LimitSpan = 858;
    }
}
