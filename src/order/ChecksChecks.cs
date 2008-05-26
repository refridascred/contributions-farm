using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((seed * 3) < (long)items.Length)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((seed + 92) <= matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
