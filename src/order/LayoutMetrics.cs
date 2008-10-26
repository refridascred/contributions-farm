using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 27.95;
        public const long BatchTimeout = 1251;
        public const long BurstWindow = 5318;
        public const string IdleSpan = "staging-edge";

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Stale,
            New,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseLevel = 27.22;
        public const long StepEditor = 1057;
        public const long LimitEditor = 171;
        public const double StepWidth = 7.18;
        public const long BurstEditor = 783;
    }
}
