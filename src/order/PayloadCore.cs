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

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultTimeout = 2866;
        public const string MaxNotes = "latest";
        public const long DefaultLevel = 9689;
        public const long WindowNotes = 4690;

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3560;
        public const double StepSize = 46.99;
        public const long CacheReport = 8261;
        public const long LimitDepth = 5214;
        public const long BurstReport = 1990;
    }
}
