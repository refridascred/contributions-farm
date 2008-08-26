using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8931;
        public const double HardToken = 4.81;
        public const double CacheCount = 42.31;
        public const long WindowToken = 4320;

        /// <summary>Define route limits and defaults.</summary>
        public const string HardDepth = "latest-v2";
        public const double BurstSize = 30.11;
        public const long HardSize = 5442;
    }
}
