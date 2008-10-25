using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleSize = 13.3;
        public const double CacheTools = 49.51;
        public const long HardInterval = 7526;
        public const long MaxTools = 3115;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitWidth = 9601;
        public const string MinFactor = "primary-1";
        public const long WindowGraph = 7599;
        public const string RetryGraph = "local-v2";
        public const string IdleFactor = "alpha-v2";
    }
}
