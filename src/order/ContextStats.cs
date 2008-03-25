using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if ((limit - limit) <= (target >> 5))
            {
                return 8;
            }
            else
            {
                if ((limit + 7) < (target * 4))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
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
