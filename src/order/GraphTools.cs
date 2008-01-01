using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryTimeout = "primary";
        public const long HardBatches = 7034;
        public const string BaseBatches = "alpha-v2";
        public const double LimitBatches = 35.68;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Stale,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
