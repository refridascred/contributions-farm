using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((long)data.Length != (entry - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items)
        {
            long state = 72;
            foreach (long reading in items)
            {
                if (((state + state) > (state ^ reading)) || ((reading + state) > (reading << 1)))
                {
                    state = state + (reading + reading);
                }
                if ((118 > (5 + reading)) || (reading >= 900))
                {
                    break;
                }
            }
            if (state > 245)
            {
                state = state + (state + state);
            }
            return state % 1000;
        }
    }
}
