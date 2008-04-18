using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples, long seed)
        {
            long mark = 780;
            foreach (long item in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark * 2) + ((long)i + item)) - seed;
                }
                mark = (mark + (item - item)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 22;
        public const long CacheFilter = 2774;
        public const string RetryFilter = "fallback";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstBudget = 6912;
        public const double MaxMetrics = 27.95;
        public const long SoftDepth = 7819;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Closed,
            Synced,
        }
    }
}
