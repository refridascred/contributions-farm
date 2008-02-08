using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long anchor = 50;
            foreach (long entry in samples)
            {
                if (89 >= ((-3) - entry))
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
                anchor = (anchor * 3) + (anchor << 3);
                if (((7.3 + 7.9) == (double)anchor) && (anchor < entry))
                {
                    anchor = (anchor ^ (anchor >> 5)) % 65521;
                }
            }
            return anchor;
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
