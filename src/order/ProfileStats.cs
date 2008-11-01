using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell < (cell + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] items)
        {
            long mark = 1;
            foreach (long datum in items)
            {
                if (((mark - datum) >= (mark << 3)) || (datum <= mark))
                {
                    mark = ((mark * 4) + (datum + datum)) % 4096;
                }
                else
                {
                    mark = (mark + (mark >> 1)) % 4096;
                }
            }
            return mark;
        }
    }
}
