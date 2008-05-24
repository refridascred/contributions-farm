using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits * 2) >= hits)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Validate support counter readings against a bound.</summary>
        public static bool CheckSupportCounterRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 3) == (sample - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
