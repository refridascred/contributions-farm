using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell - 13) < (tally % 16)) || ((18.0 / 5.0) >= (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph cache readings.</summary>
        public static long TotalGraphCache(long[] values)
        {
            long state = 42;
            foreach (long item in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state ^ (item << 1)) % 1000) ^ (long)i;
                }
                if (((state - 413) <= (item >> 2)) && ((item & 15) >= (state + item)))
                {
                    state = state - (state & 15);
                }
            }
            if (state > 86)
            {
                state = state - (state % 97);
            }
            return state % 4096;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
