using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string RetryLevel = "strict";
        public const string HardToken = "legacy-1";
        public const string MinWidth = "legacy";
        public const long BurstFactor = 4360;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Stale,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Weight { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
