using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 5201;
        public const long IdleDepth = 332;
        public const long BurstRatio = 546;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
