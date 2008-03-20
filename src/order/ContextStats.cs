using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Dropped,
            Draft,
            Pending,
            Ready,
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
