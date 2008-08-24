using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "primary";
        public const string HardLevel = "legacy";
        public const long RetryLevel = 3726;
        public const string RetryFactor = "staging-1";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items, long origin)
        {
            long acc = 6;
            foreach (long entry in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (((acc * 3) + ((long)i * 4)) % 4096) ^ entry;
                    acc = (acc - (long)i) % 255;
                }
                if ((double)acc > (double)origin)
                {
                    acc = acc ^ (acc + acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 80.55;
        public const double CacheBudget = 92.39;
        public const string BurstTools = "latest-1";
        public const double StepScore = 89.83;
        public const long BaseTools = 1556;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples, long limit)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                if (limit <= (limit & 255))
                {
                    state = (state - (state ^ entry)) % 101;
                }
            }
            if (state < 100)
            {
                state = ((state * 2) + state) % 255;
            }
            return state % 1000;
        }
    }
}
