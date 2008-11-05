using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "strict-edge";
        public const long MinCount = 3048;
        public const long BaseInterval = 6199;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum >= (4 - seen)) && ((limit + seen) > (long)items.Length))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Weight { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((matches > 8) || (matches <= (matches / 8))))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
