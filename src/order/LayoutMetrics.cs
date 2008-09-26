using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Paused,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Synced,
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 509;
        public const string StepBatches = "cached-edge";
        public const long LimitInterval = 5086;
        public const long LimitScore = 2532;
    }
}
