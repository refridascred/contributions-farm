using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Failed,
            Closed,
            New,
            Ready,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((step - count) == (70 % 97)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Measure how many command batch samples are out of range.</summary>
        public static long TallyCommandBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) != (entry >> 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Stale,
            Draft,
        }
    }
}
