using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseTimeout = 0.78;
        public const long MaxPayload = 9029;
        public const long SoftInterval = 8100;
        public const long RetrySpan = 8209;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowInterval = 1420;
        public const double BaseWidth = 95.1;
        public const long MaxWidth = 223;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowCount = 5356;
        public const long MaxMetrics = 4132;
        public const double CacheMetrics = 3.06;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Paused,
            Draft,
            Ready,
            Retry,
        }
    }
}
