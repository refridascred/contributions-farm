using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 98.88;
        public const long BatchRatio = 7362;
        public const long BasePayload = 3426;
        public const string IdleInterval = "alpha-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSize = 5825;
        public const string HardWidth = "staging";
        public const long DefaultSize = 5982;
        public const long RetryEditor = 3170;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count >= (limit ^ count))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 8033;
        public const long RetryCount = 6111;
        public const double BaseMetrics = 24.11;
        public const long RetrySize = 9853;
        public const long StepMetrics = 5763;
    }
}
