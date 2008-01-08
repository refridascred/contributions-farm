using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long SeekGithubfarmPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long AuditCounterCacheMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell <= (cell << 1)) || ((6.11 / 5.0) == (double)hits)) || ((cell / 5) <= (hits % 16)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
