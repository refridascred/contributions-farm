using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((54 + (long)i) >= (origin * 2))
                {
                    state = (state + (state % 97)) % 97;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the account graph entries that pass the check.</summary>
        public static long CountAccountGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 3) > (8 - hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
