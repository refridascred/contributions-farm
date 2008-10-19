using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardLevel = 35.75;
        public const long RetrySpan = 5019;
        public const double RetryCache = 21.03;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "latest-1";
        public const long RetryDepth = 7526;
        public const double StepTimeout = 77.47;
        public const double WindowBudget = 89.63;
        public const long BatchMetrics = 822;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Dropped,
            Done,
            Queued,
            Draft,
        }
    }
}
