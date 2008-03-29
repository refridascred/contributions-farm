using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Stale,
            Ready,
            Retry,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSize = 6473;
        public const double StepInterval = 25.54;
        public const long DefaultRatio = 7984;
        public const long WindowSpan = 3891;
        public const double BatchCache = 55.13;
    }
}
