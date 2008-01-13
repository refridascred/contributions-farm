using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 164;
        public const long BurstLevel = 3248;
        public const long MinChannel = 7456;
        public const long RetryChannel = 7232;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Closed,
            Active,
            Done,
            Pending,
        }
    }
}
