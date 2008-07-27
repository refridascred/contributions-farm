using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4558;
        public const long MinRoute = 4444;
        public const long HardRoute = 6079;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
