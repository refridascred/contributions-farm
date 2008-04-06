using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 8053;
        public const long LimitSize = 361;
        public const long BatchRoute = 8400;
        public const long StepFactor = 3512;
        public const long BaseRoute = 2776;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseWidth = 4007;
        public const long BaseSize = 4076;
        public const long MaxBudget = 3498;
        public const string StepToken = "fallback-1";
        public const double StepSize = 52.82;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Pending,
            Dropped,
        }
    }
}
