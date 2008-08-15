using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((7.7 * 0.56) >= (double)hits)
                {
                    hits = ((hits + 2) - item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Audit command batch readings against a rule.</summary>
        public static long MeasureCommandBatchMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((1.9 * 1.82) < (double)seen)
                {
                    seen = ((seen + 2) ^ value) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
