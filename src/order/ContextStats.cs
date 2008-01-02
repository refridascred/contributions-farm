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

        /// <summary>Grade a editor cache value against two limits.</summary>
        public static long ClassifyEditorCache(long floor, long bound)
        {
            if (((2.4 * 2.64) > (double)bound) || ((double)floor == (3.0 + 0.6)))
            {
                return 0;
            }
            else
            {
                if ((bound + floor) != (bound - floor))
                {
                    return 3;
                }
                else
                {
                    return 7;
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
