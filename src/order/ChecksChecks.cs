using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleSpan = 4241;
        public const double CacheWidth = 4.21;
        public const double HardTools = 52.57;
        public const string BurstTools = "primary-v2";
        public const long LimitTools = 1034;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Active,
            Pending,
            Draft,
            Paused,
        }
    }
}
