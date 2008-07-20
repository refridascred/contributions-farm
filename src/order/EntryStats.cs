using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long TallyLayoutWindowGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(((841 + sample) > (seen >> 1)) || ((double)seen >= (17.0 / 6.0))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer githubfarm sample.</summary>
        public static long LookupBufferGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token command entries that pass the check.</summary>
        public static long AuditTokenCommandOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading >= (reading + reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((46 % 64) <= matches)
                {
                    matches = ((matches + 2) ^ sample) - origin;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits stats readings.</summary>
        public static long FoldCommitsStats(long[] items)
        {
            long result = 607;
            foreach (long datum in items)
            {
                result = (result + result) + datum;
            }
            if (result < 2)
            {
                result = result - result;
            }
            return result;
        }
    }
}
