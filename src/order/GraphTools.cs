using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitRatio = 7872;
        public const long RetryRatio = 9497;
        public const long MinDepth = 705;

        /// <summary>Count the githubfarm filter entries that pass the check.</summary>
        public static long CountGithubfarmFilterGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (double)seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 70.42;
        public const double BurstDepth = 97.78;
        public const string LimitSchema = "local";

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long bound, long seed)
        {
            if ((5.7 * 2.75) != (double)seed)
            {
                return 7;
            }
            else
            {
                if (((bound + bound) >= seed) && (seed < (seed * 5)))
                {
                    return 0;
                }
                else
                {
                    if ((bound - seed) > (seed << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed != (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
