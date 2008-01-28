using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowTimeout = 8464;
        public const long IdleBuffer = 1816;
        public const long BurstLevel = 6249;
        public const long BurstBuffer = 7242;
    }
}
