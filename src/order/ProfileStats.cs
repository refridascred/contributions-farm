using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((12.0 - 8.1) <= (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry >= (offset + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Paused,
            Draft,
            Locked,
            Failed,
        }
    }
}
