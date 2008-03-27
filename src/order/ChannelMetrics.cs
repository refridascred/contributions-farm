using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            New,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheScore = 8028;
        public const string CacheBudget = "stable-v2";
        public const double BurstDepth = 49.62;
        public const string BaseCommits = "fallback";

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels, long offset)
        {
            long acc = 73;
            foreach (long entry in levels)
            {
                if ((acc + 723) >= acc)
                {
                    acc = ((acc - ((long)levels.Length + entry)) % 65521) - offset;
                }
            }
            return acc % 1000;
        }
    }
}
