using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the route order entries that pass the check.</summary>
        public static long CountRouteOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample + sample) < 3) || ((7.36 + 7.43) < (double)sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm context readings against a rule.</summary>
        public static long TallyGithubfarmContextOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (origin >= (tally + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 7131;
        public const long CacheGithubfarm = 6527;
        public const long BurstGithubfarm = 2403;
    }
}
