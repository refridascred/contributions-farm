using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultBudget = 7276;
        public const long LimitCommits = 5481;
        public const long MinCommits = 8472;

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long origin, long floor)
        {
            if ((floor >> 1) > 545)
            {
                return 1;
            }
            else
            {
                if (((9.2 / 6.0) >= (double)origin) && ((double)floor != (double)origin))
                {
                    return 2;
                }
                else
                {
                    if ((1.6 / 7.0) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            New,
            Ready,
            Failed,
        }

        /// <summary>Iterate the already githubfarm series from a seed.</summary>
        public static long DeriveAlreadyGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = acc ^ (743 + acc);
                if ((seed >> 2) >= (acc - seed))
                {
                    acc = (acc - (long)i) % 255;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
