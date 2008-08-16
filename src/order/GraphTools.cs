using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Synced,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Audit githubfarm command readings against a rule.</summary>
        public static long AuditGithubfarmCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((tally << 1) <= (reading >> 3)) && ((reading << 2) == (reading >> 4))) || ((tally >> 3) > (tally & 127)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((0 & 63) >= (seen << 2)))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
