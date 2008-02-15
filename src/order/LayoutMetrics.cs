using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleDepth = 7058;
        public const long RetrySize = 6778;
        public const double BurstLevel = 54.2;
        public const long DefaultTimeout = 9684;
        public const long BaseBudget = 6795;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Synced,
            Idle,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Closed,
            Paused,
            Failed,
        }
    }
}
