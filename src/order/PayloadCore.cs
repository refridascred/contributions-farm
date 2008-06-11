using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 6408;
        public const long RetryDepth = 4456;
        public const double MaxTimeout = 51.71;
        public const long BatchBudget = 9941;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 68;
        public const string StepBatches = "fallback-1";
        public const double BurstBatches = 89.49;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
        }
    }
}
