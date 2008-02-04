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

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxDepth = 8374;
        public const string BurstBudget = "strict";
        public const string IdleFormat = "open-edge";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Dropped,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepScore = 26.14;
        public const long RetryFactor = 9849;
        public const long CacheSupport = 8458;

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheCount = 65.9;
        public const string BaseSpan = "strict-edge";
        public const long LimitChecks = 229;
        public const long CacheChecks = 5069;
        public const long BaseChecks = 8382;
    }
}
