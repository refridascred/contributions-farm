using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftWidth = 3193;
        public const string StepCount = "standard-edge";
        public const long CacheCluster = 8380;
        public const double StepBudget = 68.03;

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 35.74;
        public const string StepFactor = "cached";
        public const double StepRoute = 35.57;
        public const double RetryRoute = 42.83;
        public const string DefaultBudget = "strict";
    }
}
