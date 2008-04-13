using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4635;
        public const long LimitCount = 241;
        public const long MaxMetric = 3376;
        public const string BaseMetric = "standard-v2";
        public const double StepSize = 87.72;

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "staging-edge";
        public const string StepWidth = "stable-edge";
        public const long RetryEntry = 4726;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Draft,
            Stale,
            Closed,
        }
    }
}
