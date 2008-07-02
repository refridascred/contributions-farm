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

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 77.11;
        public const string BaseQueue = "standard-v2";
        public const double HardRatio = 32.86;
    }
}
