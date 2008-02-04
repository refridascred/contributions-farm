using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 1433;
        public const long CacheProfile = 2259;
        public const long StepInterval = 514;
        public const long HardProfile = 3709;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Active,
            Failed,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Draft,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheCount = 65.9;
        public const string BaseSpan = "strict-edge";
        public const long LimitChecks = 229;
        public const long CacheChecks = 5069;
        public const long BaseChecks = 8382;
    }
}
