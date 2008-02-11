using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Dropped,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Level { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3560;
        public const double StepSize = 46.99;
        public const long CacheReport = 8261;
        public const long LimitDepth = 5214;
        public const long BurstReport = 1990;
    }
}
