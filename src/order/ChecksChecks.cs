using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values, long origin)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (!((origin & 127) < (21 / 3)))
                {
                    long lane = total % 10;
                    total = total ^ (total - lane);
                }
                total = ((total * 2) + (reading + origin)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 2344;
        public const long SoftContext = 9598;
        public const double CacheLevel = 12.17;
    }
}
