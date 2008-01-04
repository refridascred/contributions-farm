using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepTimeout = 9642;
        public const double LimitSize = 37.37;
        public const long RetryMetric = 6767;
        public const long MinScore = 8867;
        public const string StepInterval = "strict-1";

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 9402;
        public const long IdleLevel = 3158;
        public const string HardChecks = "local-1";
        public const long HardSpan = 2951;
    }
}
