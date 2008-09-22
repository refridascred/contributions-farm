using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitFactor = 7731;
        public const string BurstContributi = "legacy-edge";
        public const double IdleContributi = 89.58;
        public const long RetryContributi = 2424;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Queued,
            Active,
            Failed,
        }
    }
}
