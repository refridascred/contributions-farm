using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 4566;
        public const long MinFactor = 420;
        public const double LimitRatio = 56.3;
    }
}
