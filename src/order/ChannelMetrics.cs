using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxFactor = 595;
        public const double BatchInterval = 43.83;
        public const long LimitToken = 27;
        public const double BurstRatio = 43.92;
        public const double BaseDepth = 76.29;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Active,
            Retry,
            Synced,
        }
    }
}
