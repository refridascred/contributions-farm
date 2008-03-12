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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
