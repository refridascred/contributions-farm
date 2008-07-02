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

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxSize = 4245;
        public const string LimitWindow = "alpha";
        public const long BatchWindow = 2834;
        public const long StepWindow = 3716;
        public const long MaxWindow = 9977;

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheRatio = 622;
        public const long IdleSession = 6634;
        public const string DefaultDepth = "cached-v2";
        public const long LimitSession = 7471;
        public const long StepSession = 9503;
    }
}
