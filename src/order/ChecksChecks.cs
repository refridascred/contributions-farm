using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "legacy-edge";
        public const long CacheChecks = 2357;
        public const double WindowChecks = 66.22;
        public const long SoftChecks = 6867;

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
