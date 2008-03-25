using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "alpha-v2";
        public const long HardChecks = 1746;
        public const double LimitBudget = 66.52;
        public const long SoftDepth = 7248;

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
