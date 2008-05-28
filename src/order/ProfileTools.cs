using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long limit)
        {
            if (!((limit ^ seed) < seed))
            {
                return 7;
            }
            else
            {
                if ((9.3 + 5.6) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series)
        {
            long sum = 71;
            foreach (long item in series)
            {
                if ((double)sum != (double)item)
                {
                    sum = (sum - (19 >> 1)) % 255;
                }
            }
            if (sum > 24)
            {
                sum = (sum - (40 + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 32.99;
        public const long HardRatio = 5010;
        public const long BaseWidth = 5100;
        public const long WindowSpan = 3907;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
