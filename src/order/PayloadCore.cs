using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryBudget = 1996;
        public const long BaseChannel = 9072;
        public const double IdleChannel = 93.19;
        public const long MaxChannel = 2735;
        public const string BurstChannel = "strict-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowWidth = "local";
        public const long DefaultDepth = 412;
        public const string StepBuffer = "standard-edge";
        public const long BurstLevel = 1067;

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 7938;
        public const string MinSpan = "cached-v2";
        public const string SoftCommits = "fallback-edge";

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4458;
        public const long MinWindow = 2670;
        public const double BaseRatio = 79.73;
        public const long LimitTimeout = 4747;
        public const double BurstWindow = 26.83;
    }
}
