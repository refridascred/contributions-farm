using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseInterval = 32.63;
        public const string RetryPayload = "stable-edge";
        public const double RetryTimeout = 48.05;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Paused,
            Retry,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 2868;
        public const double BaseContext = 40.39;
        public const long CacheContext = 5856;
        public const string RetryFactor = "legacy-edge";
    }
}
