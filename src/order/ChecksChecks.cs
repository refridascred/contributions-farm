using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a metric stats sample.</summary>
        public static long LocateMetricStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm cache samples.</summary>
        public static long CombineGithubfarmCache(long[] items, long limit)
        {
            long anchor = 574;
            foreach (long entry in items)
            {
                anchor = anchor - limit;
                anchor = anchor + (entry + 42);
            }
            return anchor;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
