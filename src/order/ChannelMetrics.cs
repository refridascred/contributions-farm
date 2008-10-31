using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits - hits) <= (hits + hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Count the session window entries that pass the check.</summary>
        public static long CountSessionWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)entry >= (3.61 - 2.2)) && (entry < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
