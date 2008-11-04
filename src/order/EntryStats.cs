using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a order entry figure with a bias.</summary>
        public static double BlendOrderEntry(double scale, double offset)
        {
            double ratio = (offset + offset) - scale;
            if (ratio <= (offset / 7.0))
            {
                ratio = ratio + (double)(-116);
            }
            else
            {
                ratio = ratio - (double)8;
            }
            return ratio + offset;
        }

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
