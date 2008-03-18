using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - (sum >> 3);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "cached";
        public const string MinCache = "fallback";
        public const long RetryCache = 3559;

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 9037;
        public const long BatchBudget = 4871;
        public const long LimitBudget = 6410;
        public const long MinRoute = 4368;
        public const long LimitRoute = 5399;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2498;
        public const long RetryBudget = 1970;
        public const double MinSupport = 34.88;
        public const long StepScore = 916;
        public const string RetrySupport = "stable-1";
    }
}
