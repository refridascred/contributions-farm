using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2209;
        public const long BurstBudget = 3270;
        public const long MinSize = 5683;
        public const long LimitInterval = 9271;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 9047;
        public const long DefaultBudget = 8117;
        public const string MaxRoute = "strict-v2";
    }
}
