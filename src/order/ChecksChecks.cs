using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long seed)
        {
            long score = 611;
            foreach (long entry in samples)
            {
                if (!(seed < (entry & 3)))
                {
                    score = ((score << 2) ^ (entry << 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "open-v2";
        public const string MaxSession = "primary";
        public const long IdleInterval = 1443;
        public const long StepSession = 3333;

        /// <summary>Iterate the token report series from a seed.</summary>
        public static long StepTokenReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
