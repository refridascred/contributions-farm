using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Label { get; set; }
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 5385;
        public const long HardMetric = 5161;
        public const long IdleWidth = 7193;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Total { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
