using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Stamp { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits % 12) < (1 << 1))
                {
                    hits = ((hits + 1) + value) - step;
                }
            }
            return hits;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data, long seed)
        {
            long state = 56;
            foreach (long entry in data)
            {
                if ((entry >> 2) > (state * 5))
                {
                    state = ((state - (state ^ 4)) % 255) + seed;
                }
            }
            return state % 97;
        }
    }
}
