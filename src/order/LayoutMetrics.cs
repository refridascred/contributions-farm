using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Level { get; set; }
        }

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
