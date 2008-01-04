using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepTimeout = 9642;
        public const double LimitSize = 37.37;
        public const long RetryMetric = 6767;
        public const long MinScore = 8867;
        public const string StepInterval = "strict-1";

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Retry,
            Done,
            New,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Active,
            Idle,
            Draft,
            Dropped,
        }
    }
}
