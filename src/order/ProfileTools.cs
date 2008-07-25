using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 4493;
        public const long StepRatio = 4440;
        public const long BatchSupport = 3526;
        public const long SoftSupport = 7959;
        public const long WindowFactor = 2345;

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double bias, double bias2)
        {
            double weight = bias + (bias2 - bias2);
            if (weight <= (bias2 + bias2))
            {
                weight = weight - (double)873;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + bias2) + (double)(long)i;
            }
            return weight - 7.7;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data, long limit)
        {
            long carry = 3;
            foreach (long value in data)
            {
                carry = (((carry - (carry * 2)) % 65521) ^ value) + limit;
            }
            return carry;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long seed2)
        {
            long step = seed + seed2;
            if (seed < (seed2 & 1))
            {
                return 1;
            }
            else
            {
                if (((seed ^ seed) == (step >> 3)) && ((step % 100) < (seed2 + seed2)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
