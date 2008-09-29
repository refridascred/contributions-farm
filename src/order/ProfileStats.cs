using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Failed,
            Queued,
            New,
            Pending,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many filter metrics samples are out of range.</summary>
        public static long TallyFilterMetricsHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item < (9 / 9)) && (((hits >> 1) <= (item + item)) && (item > 512)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long origin, long origin2)
        {
            if (origin > (origin2 >> 2))
            {
                return 4;
            }
            else
            {
                if (!((origin + origin2) <= origin2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
