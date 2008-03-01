using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((double)cell >= (double)matches) && (((matches * 3) != (cell & 1)) || (((long)samples.Length - 24) == (cell - 841))))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
