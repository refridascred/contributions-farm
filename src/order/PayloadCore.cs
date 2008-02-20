using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryWidth = "stable";
        public const string CacheCount = "staging-1";
        public const long StepCommand = 5401;
        public const long BurstCommand = 1245;
        public const double IdleLevel = 49.22;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Retry,
            Draft,
            Stale,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxSpan = 73.76;
        public const string MaxFormat = "staging-1";
        public const string MinTimeout = "local";
        public const long SoftTimeout = 7953;
    }
}
