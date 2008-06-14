using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((double)76 <= (double)matches) && ((double)item >= (3.2 * 8.9))) && ((double)matches > 5.85))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Active,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((8.0 * 3.57) < (double)floor)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }
    }
}
