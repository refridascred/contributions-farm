using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheWidth = 8169;
        public const long BurstRoute = 9515;
        public const long BaseRoute = 8354;
        public const long RetryTimeout = 8375;
        public const long BaseTimeout = 5403;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Active,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
