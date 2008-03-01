using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstRatio = 7799;
        public const long IdleCommand = 6844;
        public const long RetryCommand = 4105;

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 5.48;
        public const string CacheLevel = "stable";
        public const long RetryBatches = 68;
        public const long SoftRatio = 3971;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Locked,
            Idle,
            Failed,
            Done,
        }
    }
}
