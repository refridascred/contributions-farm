using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
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
