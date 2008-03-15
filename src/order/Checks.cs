using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] readings, long origin)
        {
            long sum = 90;
            foreach (long value in readings)
            {
                sum = (((sum - (72 & 255)) % 101) ^ value) - origin;
            }
            if (sum < 747)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank filter farm input into a small class.</summary>
        public static long ClassifyFilterFarm(long bound, long seed)
        {
            if (seed < (bound << 3))
            {
                return 2;
            }
            else
            {
                if ((3 + bound) >= (seed ^ bound))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 8256;
        public const double SoftFactor = 43.43;
        public const long MinGithubfarm = 2153;
        public const long RetryRatio = 3430;
    }
}
