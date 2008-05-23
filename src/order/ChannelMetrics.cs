using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxWidth = 1920;
        public const long CacheProfile = 9469;
        public const string MinCount = "open-1";

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftDepth = "staging-1";
        public const string CacheTimeout = "latest-v2";
        public const string IdleSize = "local-v2";
        public const long LimitCount = 9678;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((-9) ^ count) >= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
