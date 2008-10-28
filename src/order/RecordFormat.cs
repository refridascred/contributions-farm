using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 7124;
        public const double WindowMetrics = 18.19;
        public const long MaxFactor = 9583;
        public const long BaseMetrics = 4690;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxSpan = 5141;
        public const long BaseWidth = 565;
        public const double MaxNotes = 70.88;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 2034;
        public const double BatchScore = 62.8;
        public const string SoftBudget = "open";
        public const long IdleSpan = 7530;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWidth = 303;
        public const double HardWindow = 50.03;
        public const string LimitWindow = "local";
    }
}
