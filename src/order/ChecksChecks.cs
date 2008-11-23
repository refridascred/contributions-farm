using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseTimeout = 1903;
        public const double WindowEditor = 79.36;
        public const long LimitEditor = 8307;
        public const long SoftEditor = 6424;
        public const string BurstBudget = "latest-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 787;
        public const long RetryMetric = 8461;
        public const long CacheMetric = 2051;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultInterval = 4335;
        public const long DefaultBatch = 7407;
        public const string RetryScore = "legacy-v2";
        public const long MaxBatch = 5702;
        public const long RetryBatch = 7313;
    }
}
