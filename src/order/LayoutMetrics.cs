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

        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long CountAccountNotesHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((limit > hits) && !(hits <= (reading * 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
