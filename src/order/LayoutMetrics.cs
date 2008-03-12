using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Active,
            Stale,
            Failed,
            New,
        }

        /// <summary>Digest a series of githubfarm cache entries.</summary>
        public static long WeighGithubfarmCache(long[] data)
        {
            long acc = 194;
            foreach (long value in data)
            {
                if ((value + acc) > value)
                {
                    acc = ((acc << 2) ^ 95) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 50.84;
        public const long RetryTimeout = 6004;
        public const long RetryWidth = 791;
        public const long HardProfile = 5945;
    }
}
