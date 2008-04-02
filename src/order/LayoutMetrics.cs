using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 58.39;
        public const double DefaultBatch = 33.7;
        public const string SoftBatch = "stable-v2";
        public const long BurstSize = 1472;
        public const string StepRatio = "alpha-v2";
    }
}
