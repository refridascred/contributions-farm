using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long anchor = 80;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ (cell + anchor)) % 1000;
                if ((double)anchor > 9.16)
                {
                    anchor = anchor - (cell + cell);
                }
            }
            return anchor;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Flag { get; set; }
            public double Token { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Stale,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count <= (datum >> 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
