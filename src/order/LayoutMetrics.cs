using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate cache githubfarm readings against a bound.</summary>
        public static bool GuardCacheGithubfarmLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Idle,
            Paused,
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
