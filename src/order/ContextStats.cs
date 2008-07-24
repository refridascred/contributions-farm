using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (sample < (hits >> 1))
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Dropped,
            Stale,
            Ready,
            Retry,
        }
    }
}
