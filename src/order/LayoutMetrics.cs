using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "primary-v2";
        public const long IdleBudget = 7961;
        public const double BurstLevel = 92.68;
    }
}
