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

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((bound - matches) != (7 + bound))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics batches readings against a bound.</summary>
        public static bool ValidateMetricsBatchesLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
