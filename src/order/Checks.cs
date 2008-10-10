using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long limit, long bound)
        {
            if ((bound > ((-71) >> 4)) || ((18.0 - 6.0) == (double)limit))
            {
                return 8;
            }
            else
            {
                if ((limit & 255) > limit)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double floor)
        {
            double bias = (double)1;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - (bias / 2.0)) + (double)(long)i) + scale) + floor;
            }
            return bias + bias;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long offset)
        {
            long slot = floor - offset;
            if (((7 + offset) < (floor >> 2)) || ((0.43 + 3.77) == (double)floor))
            {
                return 1;
            }
            else
            {
                if (!(slot < 280))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long score = 3;
            foreach (long datum in samples)
            {
                score = (score - ((long)samples.Length - datum)) % 97;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "legacy-v2";
        public const long LimitWidth = 8715;
        public const string BaseLevel = "latest";
        public const long DefaultChecks = 6467;
    }
}
