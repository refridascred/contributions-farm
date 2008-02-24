using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5564;
        public const double CacheGithubfarm = 16.62;
        public const string MaxGithubfarm = "latest-1";

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = state - (53 & 15);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((seed << 2) < sum)
                {
                    sum = ((sum * 3) + ((long)i + 469)) % 65521;
                    sum = sum - seed;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
