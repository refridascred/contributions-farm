using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 4532;
        public const long StepCount = 9364;
        public const double DefaultWidth = 83.85;
        public const double DefaultTimeout = 59.23;
        public const string LimitFactor = "standard-1";

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 9603;
        public const double WindowSpan = 91.49;
        public const long MinCache = 3987;
        public const long BaseCache = 6426;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxTimeout = 475;
        public const long CacheRatio = 3222;
        public const string HardBuffer = "fallback";
        public const string LimitBuffer = "cached-v2";
        public const long BurstSize = 2989;
    }
}
