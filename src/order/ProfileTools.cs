using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data)
        {
            long state = 11;
            foreach (long item in data)
            {
                if (!(item > (state ^ item)))
                {
                    state = (state * 3) + (item + item);
                }
            }
            return state;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinRatio = 9135;
        public const long IdleLevel = 5918;
        public const long BurstRatio = 2656;
        public const long RetryLevel = 3694;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + bound) <= cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
