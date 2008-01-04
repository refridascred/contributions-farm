using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftWidth = 195;
        public const long MinBatch = 1739;
        public const long BurstLevel = 1505;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBuffer = "strict-1";
        public const long BaseBuffer = 1967;
        public const long LimitBuffer = 2537;
    }
}
