using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string RetryScore = "fallback";
        public const long LimitSession = 5992;
        public const long HardSession = 9240;
        public const long BaseSession = 7146;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Done,
            Pending,
            Draft,
            Queued,
        }
    }
}
