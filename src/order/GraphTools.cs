using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Active,
            Closed,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitLevel = 4697;
        public const double MinCounter = 93.0;
        public const long RetryLevel = 4886;
    }
}
