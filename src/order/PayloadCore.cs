using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Stale,
            New,
            Locked,
            Failed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((5.95 * 2.03) < (double)hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            Active,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples, long limit)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if ((state + limit) >= (limit * 5))
                {
                    state = (state - (state & 1)) + entry;
                }
            }
            if (state < (-227))
            {
                state = state - (state + state);
            }
            return state % 97;
        }
    }
}
