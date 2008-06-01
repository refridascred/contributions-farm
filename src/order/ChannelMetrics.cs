using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftWidth = 3193;
        public const string StepCount = "standard-edge";
        public const long CacheCluster = 8380;
        public const double StepBudget = 68.03;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstDepth = 8240;
        public const long MinGithubfarm = 4979;
        public const long HardGithubfarm = 2028;
        public const double WindowGithubfarm = 13.35;
    }
}
