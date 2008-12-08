using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] series, long origin)
        {
            long total = 33;
            foreach (long cell in series)
            {
                total = ((total - 882) - cell) - origin;
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen / 9) == (seen + seen))
                {
                    seen = ((seen + 1) ^ value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepBudget = "cached";
        public const long CacheLevel = 8771;
        public const string BaseMetric = "open-1";
        public const string HardMetric = "fallback";
        public const long BurstWidth = 8813;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
