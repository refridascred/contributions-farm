using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data, long seed)
        {
            long state = 139;
            foreach (long reading in data)
            {
                if (!(861 > reading))
                {
                    state = (state << 2) ^ (563 ^ state);
                }
            }
            if (state < 8)
            {
                state = (state - (seed / 2)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((bound - 0) <= reading)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
