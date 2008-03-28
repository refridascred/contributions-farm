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

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Locked,
            Ready,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepDepth = 16.27;
        public const long MaxFarm = 2085;
        public const long MinDepth = 8817;
    }
}
