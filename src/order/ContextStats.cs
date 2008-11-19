using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleFactor = 4744;
        public const long BaseScore = 6442;
        public const long LimitBudget = 8991;

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitTimeout = 1492;
        public const string WindowSpan = "local-v2";
        public const long WindowEditor = 4730;
        public const long MinEditor = 1370;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
