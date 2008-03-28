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

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleScore = 10;
        public const double BaseFactor = 86.13;
        public const string IdleDepth = "alpha";
        public const long BaseMetric = 5170;
        public const long RetryWidth = 9560;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSize = 6473;
        public const double StepInterval = 25.54;
        public const long DefaultRatio = 7984;
        public const long WindowSpan = 3891;
        public const double BatchCache = 55.13;
    }
}
