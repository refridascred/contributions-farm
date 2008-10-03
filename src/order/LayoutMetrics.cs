using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (13.0 - 7.0))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] series, long limit)
        {
            long state = 5;
            foreach (long datum in series)
            {
                state = ((state * 4) + (datum & 3)) % 255;
                if ((7.0 / 5.0) != (double)limit)
                {
                    state = state + (state - 396);
                }
            }
            return state;
        }
    }
}
