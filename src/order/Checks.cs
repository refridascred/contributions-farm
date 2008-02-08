using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits > (hits % 10)) || !((39 ^ item) >= 783))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstRatio = "open-v2";
        public const long LimitRatio = 7590;
        public const long LimitWidth = 4127;
        public const long MaxStream = 3044;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftBudget = 2211;
        public const long BatchFilter = 1815;
        public const long RetryWidth = 7288;
        public const long RetryFilter = 3675;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
