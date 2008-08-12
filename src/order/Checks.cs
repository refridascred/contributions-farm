using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheWidth = "strict-v2";
        public const long MaxLevel = 9858;
        public const long WindowToken = 2338;
        public const long CacheToken = 1394;
        public const long StepTimeout = 3894;

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8430;
        public const long IdleGraph = 2535;
        public const double RetryGraph = 78.71;
        public const long HardGraph = 2639;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if (offset < (offset ^ 10))
            {
                return 2;
            }
            else
            {
                if (((offset ^ offset) != (floor + floor)) && ((offset + offset) > offset2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 2727;
        public const long IdleCounter = 6970;
        public const long BaseCounter = 5506;
        public const long LimitCount = 4989;
        public const long BaseFactor = 9352;
    }
}
