using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series)
        {
            long mix = 784;
            foreach (long item in series)
            {
                mix = mix ^ 60;
                mix = (mix << 3) ^ item;
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 0.21;
        public const long CacheGithubfarm = 7668;
        public const string MaxScore = "stable";

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Idle,
            Draft,
            Synced,
        }
    }
}
