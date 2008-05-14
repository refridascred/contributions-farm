using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 5017;
        public const long IdleNotes = 1808;
        public const double CacheWidth = 45.95;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
