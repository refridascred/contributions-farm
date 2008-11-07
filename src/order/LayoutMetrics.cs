using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitScore = 3003;
        public const long RetryRecord = 5620;
        public const long CacheFactor = 2613;
        public const long BurstRecord = 3633;
        public const double RetryScore = 21.93;
    }
}
