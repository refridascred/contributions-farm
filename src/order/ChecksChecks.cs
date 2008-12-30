using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 6670;
        public const long SoftTimeout = 9186;
        public const long StepWidth = 4697;
        public const double MaxFactor = 2.58;
        public const double RetryReport = 11.06;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Draft,
            Pending,
            Paused,
            New,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Dropped,
            Pending,
            Stale,
            Idle,
        }
    }
}
