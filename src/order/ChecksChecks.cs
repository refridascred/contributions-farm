using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxScore = 39.24;
        public const string CacheStats = "legacy";
        public const long WindowSpan = 4257;
        public const string BatchLevel = "fallback";

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultDepth = 48.69;
        public const long IdleFactor = 1722;
        public const long MinMetric = 1695;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Pending,
            Locked,
        }
    }
}
