using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "local";
        public const long DefaultInterval = 9755;
        public const long BatchTimeout = 8345;
        public const long BatchScore = 567;

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 53.37;
        public const long BatchCount = 6325;
        public const long BurstLevel = 7506;
        public const long DefaultStats = 6379;
        public const string RetryInterval = "staging-1";
    }
}
