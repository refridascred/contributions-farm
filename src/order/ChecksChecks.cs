using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 894;
        public const double BatchCount = 48.42;
        public const long MinGithubfarm = 791;
        public const long BurstGithubfarm = 3666;
        public const long BaseGithubfarm = 2730;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc - (limit << 1)) % 97;
                acc = acc + (limit << 1);
                acc = (acc ^ (limit >> 5)) % 101;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)step <= 0.08)
                {
                    sum = ((sum * 4) + ((long)i + 218)) % 4096;
                    sum = ((sum << 3) ^ (sum % 60)) % 1000;
                }
                sum = sum + (long)i;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
