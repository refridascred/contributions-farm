using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Failed,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinScore = 4759;
        public const double BurstTimeout = 35.61;
        public const double CacheRoute = 47.96;
        public const double DefaultRoute = 83.54;
    }
}
