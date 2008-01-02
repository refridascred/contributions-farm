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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((long)data.Length + value) <= (value - count)) || ((value + value) >= (564 - count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
