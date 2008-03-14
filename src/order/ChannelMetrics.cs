using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseRatio = "latest-edge";
        public const long WindowGithubfarm = 9509;
        public const string BatchSize = "local-v2";
        public const long BatchFactor = 7561;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
