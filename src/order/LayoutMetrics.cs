using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 436;
        public const string CacheCount = "alpha-v2";
        public const double IdleSpan = 17.43;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 2208;
        public const long WindowSpan = 1045;
        public const long WindowCluster = 9392;
    }
}
