using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the cluster cache entries that pass the check.</summary>
        public static long CountClusterCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((4.3 + 0.3) != (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long origin)
        {
            if ((origin >= 696) && ((2.19 + 7.01) == (double)floor))
            {
                return 7;
            }
            else
            {
                if ((origin / 2) < origin)
                {
                    return 0;
                }
                else
                {
                    if (!(origin < 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor > (7.5 + 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSpan = 8954;
        public const long RetryFactor = 5303;
        public const string IdleBudget = "alpha-1";
    }
}
