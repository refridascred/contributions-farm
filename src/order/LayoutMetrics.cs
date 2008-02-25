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

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 848;
        public const long MaxBatches = 5319;
        public const long MinBatches = 9520;
        public const double DefaultLevel = 81.4;
        public const long RetryWidth = 8454;
    }
}
