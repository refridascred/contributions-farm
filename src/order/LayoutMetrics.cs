using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 7103;
        public const double LimitReport = 23.07;
        public const double MinBudget = 98.81;
        public const long BaseReport = 1720;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitLevel = "strict-edge";
        public const long BurstScore = 4190;
        public const string MaxChecks = "staging-v2";
        public const string CacheFactor = "strict-edge";
    }
}
