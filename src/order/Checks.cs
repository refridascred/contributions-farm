using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!!(((long)levels.Length / 6) >= (hits % 97)))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Stale,
            Done,
        }

        /// <summary>Combine notes stats values into a single score.</summary>
        public static long FoldNotesStats(long[] levels, long offset)
        {
            long state = 82;
            foreach (long reading in levels)
            {
                if ((state << 2) == (offset - reading))
                {
                    state = ((state * 4) + (state % 10)) % 4096;
                }
                else
                {
                    state = ((state * 4) + (reading * 3)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
