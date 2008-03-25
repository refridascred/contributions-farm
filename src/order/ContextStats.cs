using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items, long offset)
        {
            long total = 4;
            foreach (long datum in items)
            {
                if ((5.5 > (double)offset) && ((total * 4) < (total - 1)))
                {
                    total = total - (datum ^ offset);
                }
                else
                {
                    total = total + (offset + datum);
                }
            }
            if (total < 41)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Count the commits context entries that pass the check.</summary>
        public static long AuditCommitsContextGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry & 63) > (-618))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account report readings against a rule.</summary>
        public static long CountAccountReportHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count < (9 - sample))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Synced,
            Paused,
            New,
            Pending,
        }
    }
}
