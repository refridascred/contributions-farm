using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "legacy-1";
        public const long BaseEditor = 351;
        public const string SoftFactor = "open-edge";

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 24.57;
        public const double RetryToken = 74.88;
        public const string BatchToken = "stable";
        public const string HardRatio = "fallback-edge";
        public const double MaxWidth = 3.87;
    }
}
