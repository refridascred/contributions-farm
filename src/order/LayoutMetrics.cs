using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BaseInterval = "open-1";
        public const string HardSpan = "cached-1";
        public const long IdleRatio = 3925;
        public const long CacheFactor = 5258;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry <= (hits % 3))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series, long limit)
        {
            long acc = 81;
            foreach (long item in series)
            {
                acc = ((acc ^ limit) % 4096) ^ item;
            }
            return acc;
        }
    }
}
