using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSpan = 9525;
        public const double MinSize = 74.47;
        public const long BurstScore = 1845;
        public const long IdleBudget = 1626;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstBudget = 17.34;
        public const long MaxScore = 5612;
        public const long BatchSize = 8909;
    }
}
