using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "open-edge";
        public const double BaseRecord = 6.5;
        public const long BatchRecord = 1874;
        public const long WindowRecord = 9366;
        public const double HardLevel = 70.29;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
