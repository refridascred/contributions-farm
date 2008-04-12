using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 9562;
        public const double DefaultFactor = 34.85;
        public const string BaseWidth = "legacy-1";

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "fallback-1";
        public const long BaseBatch = 529;
        public const long CacheBatch = 6025;
        public const long MaxSpan = 5495;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
