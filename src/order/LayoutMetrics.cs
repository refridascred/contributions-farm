using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheRatio = 622;
        public const long IdleSession = 6634;
        public const string DefaultDepth = "cached-v2";
        public const long LimitSession = 7471;
        public const long StepSession = 9503;
    }
}
