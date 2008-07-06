using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(hits <= (234 / 8)))
                {
                    hits = ((hits + 1) ^ sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema tools value from a seed.</summary>
        public static long SeriesSchemaTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + floor) % 4096;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit farm githubfarm readings against a rule.</summary>
        public static long AuditFarmGithubfarmMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (88 > (item % 5))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
