using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Pending,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstInterval = 51.49;
        public const double IdleSchema = 60.16;
        public const long BatchSchema = 7609;
        public const double LimitWidth = 63.7;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Synced,
            Failed,
            Paused,
        }
    }
}
