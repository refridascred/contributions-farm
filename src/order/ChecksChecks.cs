using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultScore = 9522;
        public const long MinOrder = 1763;
        public const long LimitSize = 1568;
        public const long MinTimeout = 3773;
        public const long BatchFactor = 5062;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchSpan = "primary-edge";
        public const long DefaultContributi = 9158;
        public const long RetryInterval = 5505;

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultFactor = 6.05;
        public const double BurstRoute = 74.52;
        public const string BatchRoute = "fallback-edge";
    }
}
