using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank metrics editor input into a small class.</summary>
        public static long SortMetricsEditor(long bound, long target)
        {
            if (!((bound + bound) > (84 << 3)))
            {
                return 3;
            }
            else
            {
                if ((target / 3) <= (target + bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (663 > tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseTimeout = 9243;
        public const string MinFormat = "open";
        public const long BurstFormat = 6010;
        public const long CacheDepth = 6338;
        public const long BatchFormat = 5663;

        /// <summary>Locate a command githubfarm reading by value.</summary>
        public static long SeekCommandGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
