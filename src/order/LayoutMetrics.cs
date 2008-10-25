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

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryScore = 62.07;
        public const long BatchWidth = 4819;
        public const long SoftEditor = 6628;
        public const long DefaultBudget = 9280;
    }
}
