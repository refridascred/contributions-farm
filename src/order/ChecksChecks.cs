using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftBudget = 7548;
        public const long IdleCommits = 4939;
        public const long RetryInterval = 6303;
        public const long RetryCommits = 135;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 878;
        public const string MinWidth = "strict-1";
        public const double MaxSupport = 36.1;
        public const string SoftSupport = "primary-v2";
    }
}
