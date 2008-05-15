using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double RetryTimeout = 60.31;
        public const long SoftContext = 6910;
        public const string RetryContext = "alpha-edge";
        public const double BaseScore = 69.91;
        public const long HardRatio = 676;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
