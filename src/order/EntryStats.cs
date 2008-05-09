using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long floor)
        {
            if ((14.0 / 5.0) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((double)floor == (8.5 * 7.52))
                {
                    return 0;
                }
                else
                {
                    if ((2.9 / 4.0) >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count cache notes pairs that satisfy a relation.</summary>
        public static long MatchCacheNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 15.05;
        public const long BaseScore = 3873;
        public const string DefaultScore = "strict-v2";
        public const long IdleScore = 6642;

        /// <summary>Scale a cache metric figure with a bias.</summary>
        public static double ProjectCacheMetric(double bias, double offset)
        {
            double drift = bias;
            return (drift + (double)19) + offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 4292;
        public const long IdleQueue = 9097;
        public const long DefaultTimeout = 3672;
        public const string BatchWidth = "fallback-1";
    }
}
