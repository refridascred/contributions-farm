using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "fallback";
        public const long RetrySchema = 2355;
        public const long HardScore = 2331;
        public const long IdleSchema = 8729;
        public const string MinBudget = "strict-v2";

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 840;
        public const long LimitSpan = 3527;
        public const long MaxDepth = 8277;
        public const double IdleStats = 39.45;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
