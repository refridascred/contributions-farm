using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 6502;
        public const double LimitCount = 20.09;
        public const long HardFarm = 3628;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "standard-v2";
        public const string BurstTimeout = "primary";
        public const string BatchTimeout = "alpha-v2";
        public const long BatchEditor = 9807;
        public const string WindowBudget = "alpha";

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long target)
        {
            long bound = seed ^ target;
            if (((1 - seed) > (target + seed)) || ((seed + bound) >= bound))
            {
                return 8;
            }
            else
            {
                if ((double)target > (7.0 + 2.0))
                {
                    return 5;
                }
                else
                {
                    if (((87 >> 4) >= ((-1) - bound)) && ((bound / 9) >= (bound - bound)))
                    {
                        return 2;
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
