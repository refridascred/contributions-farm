using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 9060;
        public const long WindowSession = 4943;
        public const long CacheSession = 4648;
        public const long BatchSession = 7968;
        public const long LimitSession = 5332;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 6664;
        public const string BatchBudget = "fallback-1";
        public const long RetryChannel = 6929;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((9.0 + 4.8) != (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
