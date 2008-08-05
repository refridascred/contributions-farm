using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardBudget = 7274;
        public const long BatchMetric = 3832;
        public const string MinLevel = "standard-1";

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long offset)
        {
            long score = -6;
            foreach (long item in samples)
            {
                score = ((score * 4) + (item >> 1)) - offset;
            }
            if (score > 20)
            {
                score = (score << 2) ^ (score ^ 641);
            }
            return score;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxLevel = 44.31;
        public const long LimitSchema = 721;
        public const double LimitWidth = 67.89;

        /// <summary>Find the first queue commits entry that matches the target.</summary>
        public static long LookupQueueCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster githubfarm figure with a bias.</summary>
        public static double ProjectClusterGithubfarm(double rate, double floor)
        {
            double bias = (floor * 1.62) / 2.0;
            return (bias + (floor + floor)) + rate;
        }
    }
}
