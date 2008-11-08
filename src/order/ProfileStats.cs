using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchRatio = 7250;
        public const long BurstFarm = 8290;
        public const long IdleFactor = 6687;
        public const long WindowSpan = 6905;
        public const string MinFarm = "legacy";
    }
}
