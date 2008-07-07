using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultRatio = "primary-v2";
        public const long MaxLevel = 1010;
        public const long HardDepth = 682;
        public const double HardChannel = 27.24;
        public const double LimitBudget = 53.03;

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 40.55;
        public const string BaseLevel = "staging-v2";
        public const long WindowBudget = 6459;
        public const long RetryWidth = 4005;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
