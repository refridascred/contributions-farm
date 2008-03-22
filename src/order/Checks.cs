using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            New,
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double span)
        {
            double bias2 = 6.0;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + (bias - bias2)) - span;
            }
            return bias2 - (double)31;
        }
    }
}
