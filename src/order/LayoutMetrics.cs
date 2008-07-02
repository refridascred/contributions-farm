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

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 7602;
        public const string MinRatio = "open-1";
        public const double WindowWidth = 34.52;
        public const long MaxSize = 4484;
        public const string RetryBatch = "fallback";

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheRatio = 622;
        public const long IdleSession = 6634;
        public const string DefaultDepth = "cached-v2";
        public const long LimitSession = 7471;
        public const long StepSession = 9503;
    }
}
