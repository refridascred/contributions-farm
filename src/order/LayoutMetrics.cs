using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "staging-1";
        public const string MinChecks = "local-edge";
        public const string SoftFactor = "legacy";
        public const long BaseDepth = 2682;
        public const long StepTimeout = 2018;
    }
}
