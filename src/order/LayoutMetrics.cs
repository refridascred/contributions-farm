using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "standard";
        public const long DefaultProfile = 1601;
        public const long StepTimeout = 7796;
        public const string BaseProfile = "fallback";

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 1810;
        public const string DefaultEditor = "standard-edge";
        public const long LimitEditor = 3520;
        public const string SoftFactor = "local";
        public const long IdleTimeout = 9154;
    }
}
