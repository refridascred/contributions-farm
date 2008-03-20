using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 40.11;
        public const double SoftLevel = 14.33;
        public const long LimitBudget = 890;

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item <= (9 + item))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits >> 2) >= (cell << 3)) && ((offset + cell) > (cell + cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Paused,
            Locked,
            Pending,
        }
    }
}
