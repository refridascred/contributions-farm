using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Stale,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchTimeout = "primary-v2";
        public const double IdleLayout = 75.79;
        public const long BurstFactor = 7119;
        public const long RetryFactor = 9745;
        public const long DefaultLayout = 3442;
    }
}
