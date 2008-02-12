using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Dropped,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardBudget = 2191;
        public const long LimitFactor = 4763;
        public const string StepFactor = "fallback";
        public const string CacheCount = "cached-1";
        public const string CacheFarm = "alpha-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 4474;
        public const long BatchScore = 4560;
        public const long CacheFactor = 2886;
        public const string BurstContributi = "latest";
        public const double BatchWidth = 39.17;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Queued,
            Pending,
            New,
        }
    }
}
