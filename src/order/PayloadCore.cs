using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxWidth = 2802;
        public const long DefaultRoute = 3287;
        public const long MaxRoute = 4381;
        public const double IdleSpan = 29.5;
        public const long MaxSize = 8940;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 4522;
        public const double RetryGithubfarm = 35.22;
        public const long WindowGithubfarm = 4791;

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 67.49;
        public const long HardScore = 613;
        public const long CacheLevel = 3473;

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleBudget = 26.48;
        public const long WindowInterval = 4365;
        public const long BurstSupport = 8892;
        public const string CacheSupport = "local";
    }
}
