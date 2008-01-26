using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            Draft,
            New,
            Synced,
        }

        /// <summary>Iterate the record githubfarm series from a seed.</summary>
        public static long IterateRecordGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!(5.12 > (double)state))
                {
                    state = (state ^ (state * 4)) % 1000;
                }
                else
                {
                    state = (state - ((long)i ^ 83)) % 1000;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "standard-v2";
        public const double BurstFarm = 80.53;
        public const long SoftBudget = 5712;

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long target)
        {
            if ((bound % 97) > (target % 10))
            {
                return 4;
            }
            else
            {
                if ((4.9 * 17.0) == (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((15.0 > (double)bound) && ((target / 6) == (target + (-3))))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + target) <= (bound % 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
