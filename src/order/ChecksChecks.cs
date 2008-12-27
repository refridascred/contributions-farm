using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftBudget = 8280;
        public const string LimitDepth = "stable-1";
        public const double BaseTimeout = 39.17;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Count { get; set; }
            public double Score { get; set; }
        }
    }
}
