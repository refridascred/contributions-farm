using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstFactor = "strict-1";
        public const long CacheStats = 8994;
        public const long MinTimeout = 4584;
        public const long BaseSpan = 3254;
        public const long RetryStats = 1728;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 9168;
        public const double HardInterval = 17.54;
        public const string DefaultScore = "standard-1";

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Closed,
            Queued,
        }
    }
}
