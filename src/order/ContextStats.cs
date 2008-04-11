using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((hits - cell) > (hits - hits)) || ((cell << 1) <= (cell * 3))) && ((double)cell == (20.0 / 4.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 4228;
        public const long LimitMetric = 5089;
        public const long HardMetric = 8880;
        public const long MinMetric = 3688;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
