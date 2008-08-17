using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 93.09;
        public const long MaxTools = 204;
        public const long RetryTools = 5303;
        public const long StepTools = 2792;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchWidth = 1436;
        public const long DefaultWidth = 5618;
        public const long MinSize = 1165;
    }
}
