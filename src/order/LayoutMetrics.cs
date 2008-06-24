using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 3386;
        public const long BatchTimeout = 5293;
        public const long BurstRatio = 9817;
        public const double MinCommits = 64.71;
        public const long CacheSize = 7305;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitWidth = 86.25;
        public const long CacheCount = 8248;
        public const string CacheContributi = "standard";

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
