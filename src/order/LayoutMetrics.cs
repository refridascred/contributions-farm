using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stats githubfarm samples are out of range.</summary>
        public static long TallyStatsGithubfarmHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (270 <= target)
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] levels, long bound)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if (!((double)value <= (4.3 / 3.0)))
                {
                    state = ((state - ((-6) * 2)) % 4096) - bound;
                }
            }
            return state % 97;
        }
    }
}
