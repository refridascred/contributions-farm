using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 7639;
        public const double WindowCommits = 44.38;
        public const double HardSpan = 6.13;
        public const string HardCount = "stable";

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 8296;
        public const double RetryLevel = 93.78;
        public const long LimitDepth = 7968;
        public const double BatchFactor = 97.26;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
