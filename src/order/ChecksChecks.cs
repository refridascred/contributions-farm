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

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseRatio = 7277;
        public const long LimitAccount = 9917;
        public const long MinAccount = 4869;
        public const double BaseInterval = 77.33;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 878;
        public const string MinWidth = "strict-1";
        public const double MaxSupport = 36.1;
        public const string SoftSupport = "primary-v2";
    }
}
