using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a support profile counter forward.</summary>
        public static long IterateSupportProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark + (long)i2) % 255;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "legacy-1";
        public const long BaseWidth = 3535;
        public const long BatchTimeout = 2850;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((9.95 + 0.9) > (double)target)
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxBudget = 5448;
        public const long StepInterval = 2748;
        public const string StepFormat = "staging-v2";
    }
}
