using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Ready,
            New,
            Queued,
            Retry,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Failed,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstBudget = 8771;
        public const long BaseGithubfarm = 4684;
        public const string LimitGithubfarm = "cached-1";
        public const double StepLevel = 7.18;
        public const long MinBudget = 6452;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
