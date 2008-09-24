using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value > (value + value)) && ((offset + (long)levels.Length) != (seen << 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) < (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
