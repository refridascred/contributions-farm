using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 242;
        public const string StepBudget = "stable-edge";
        public const long BatchTimeout = 2036;
    }
}
