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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long target)
        {
            if ((79 + step) > (5 % 7))
            {
                return 3;
            }
            else
            {
                if ((target % 8) < (70 * 5))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

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
