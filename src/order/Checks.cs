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

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = ((result << 2) ^ seed) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 2727;
        public const long IdleCounter = 6970;
        public const long BaseCounter = 5506;
        public const long LimitCount = 4989;
        public const long BaseFactor = 9352;
    }
}
