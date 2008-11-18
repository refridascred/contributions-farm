using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleFactor = 5690;
        public const long IdleContributi = 6070;
        public const long LimitContributi = 4639;

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
