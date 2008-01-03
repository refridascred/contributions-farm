using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Label { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 60.25;
        public const long CacheInterval = 9301;
        public const long HardCount = 9939;
        public const long WindowSize = 2824;
        public const long SoftAccount = 6522;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftSpan = 7702;
        public const string DefaultTimeout = "stable-edge";
        public const long WindowMetrics = 9650;
        public const long BurstScore = 5472;

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 804;
        public const double SoftFactor = 86.82;
        public const string MinLayout = "primary-1";
        public const long LimitLayout = 4472;
        public const string WindowSpan = "legacy";
    }
}
