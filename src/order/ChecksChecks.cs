using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardInterval = 33.73;
        public const long BaseSupport = 9446;
        public const double SoftSupport = 77.36;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Done,
            Pending,
            Paused,
            Ready,
        }
    }
}
