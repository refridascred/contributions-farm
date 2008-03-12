using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseLevel = 3637;
        public const long DefaultInterval = 6176;
        public const string WindowGraph = "latest-1";
        public const string CacheCount = "local-v2";
        public const double IdleGraph = 98.4;

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftSpan = 5492;
        public const string IdleLevel = "local";
        public const long WindowMetric = 4972;
        public const string StepSpan = "stable-1";
    }
}
