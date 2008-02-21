using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSchema = "cached-1";
        public const long BatchScore = 7088;
        public const long IdleSchema = 3928;
        public const double HardScore = 19.71;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Stale,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Retry,
            Failed,
        }
    }
}
