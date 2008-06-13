using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 4283;
        public const string StepRecord = "stable-v2";
        public const long IdleWidth = 5846;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchRatio = "standard-1";
        public const long BaseBudget = 1153;
        public const long IdleCommits = 277;
        public const double WindowCommits = 51.68;
        public const long SoftBudget = 7114;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Pending,
            Retry,
        }
    }
}
