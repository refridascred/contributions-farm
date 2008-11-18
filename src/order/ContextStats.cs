using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long floor, long offset)
        {
            if (floor < (offset * 3))
            {
                return 1;
            }
            else
            {
                if (92 < (floor << 1))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((floor & 15) == (hits + hits))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Retry,
            Locked,
            Queued,
            Done,
        }
    }
}
