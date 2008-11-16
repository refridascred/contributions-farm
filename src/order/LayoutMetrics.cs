using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((5 - datum) < (seen >> 1))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (607 >= (matches >> 4))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }
    }
}
