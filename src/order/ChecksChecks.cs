using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "primary";
        public const long BurstFormat = 2099;
        public const string LimitSize = "open-edge";
        public const double RetryFormat = 50.17;
        public const long LimitSpan = 6020;
    }
}
