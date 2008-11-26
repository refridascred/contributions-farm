using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 583;
        public const double BaseLevel = 59.31;
        public const double SoftWidth = 38.61;
        public const long RetryContext = 7337;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Pending,
            Stale,
        }
    }
}
