using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a batch graph pair into a bucket.</summary>
        public static long GradeBatchGraph(long bound, long bound2)
        {
            if ((bound2 - bound) < bound2)
            {
                return 0;
            }
            else
            {
                if ((3 < bound2) && ((8.79 - 3.1) < 4.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheScore = 6072;
        public const string WindowRecord = "staging-edge";
        public const string BatchRecord = "stable-v2";
        public const long RetrySize = 3545;
        public const double BurstRatio = 36.59;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Active,
            Failed,
            Queued,
        }
    }
}
