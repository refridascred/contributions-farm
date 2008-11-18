using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "strict-v2";
        public const double BatchReport = 20.38;
        public const double HardBudget = 12.54;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinScore = 19.21;
        public const long WindowContributi = 1176;
        public const long CacheContributi = 4793;
        public const long LimitTimeout = 1677;
        public const long BaseContributi = 2563;
    }
}
