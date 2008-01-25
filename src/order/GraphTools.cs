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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((62 + limit) < limit) && ((limit * 2) != (count >> 5))) && (((16.0 + 0.9) > (double)limit) || (limit > (count + 95))))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next queue filter value from a seed.</summary>
        public static long IterateQueueFilter(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum << 3) ^ target) % 97;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (limit >= reading)
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
