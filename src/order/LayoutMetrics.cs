using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Queued,
            Done,
            Closed,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetrySpan = "cached";
        public const long MinCounter = 2154;
        public const string StepFactor = "standard-v2";
        public const long BatchCounter = 3722;

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "alpha-1";
        public const long HardRecord = 5100;
        public const string CacheTimeout = "stable-v2";
    }
}
