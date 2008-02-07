using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits << 1) >= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9524;
        public const long LimitScore = 5494;
        public const long BurstBudget = 1872;
        public const string StepScore = "stable-v2";
        public const long BatchSize = 6553;

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseDepth = "strict-v2";
        public const double RetryStream = 0.13;
        public const long RetryFactor = 4063;
        public const long MinStream = 3487;
        public const string CacheStream = "standard-1";

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
