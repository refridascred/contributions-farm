using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardRatio = 1545;
        public const long MinTimeout = 5109;
        public const long MaxAlready = 3680;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Synced,
            Draft,
        }
    }
}
