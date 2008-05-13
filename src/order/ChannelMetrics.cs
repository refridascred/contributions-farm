using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftCount = 5512;
        public const long SoftProfile = 2769;
        public const long DefaultDepth = 564;

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 55.58;
        public const string MaxWidth = "fallback";
        public const long RetryLevel = 4970;
        public const long StepBudget = 1669;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Paused,
            Draft,
            Ready,
            Idle,
        }
    }
}
