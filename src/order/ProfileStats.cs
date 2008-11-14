using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
