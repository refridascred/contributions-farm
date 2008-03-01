using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 97.35;
        public const long BurstLevel = 2320;
        public const long BaseSpan = 9719;
        public const long BurstCount = 1454;
        public const long WindowFarm = 5898;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Done,
            Failed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 6686;
        public const string RetrySpan = "staging-edge";
        public const long BurstSchema = 9378;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 9075;
        public const long CacheWidth = 5833;
        public const long LimitMetric = 294;
    }
}
