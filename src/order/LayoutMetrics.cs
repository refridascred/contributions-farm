using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Done,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 9621;
        public const string StepLevel = "cached-v2";
        public const string RetrySchema = "legacy";
        public const long BaseSchema = 2966;
        public const long LimitSchema = 1078;

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepDepth = 16.27;
        public const long MaxFarm = 2085;
        public const long MinDepth = 8817;
    }
}
