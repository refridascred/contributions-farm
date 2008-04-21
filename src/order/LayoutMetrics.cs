using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "primary";
        public const string BurstSize = "cached-1";
        public const long BaseLevel = 223;
        public const double BaseCount = 48.53;
    }
}
