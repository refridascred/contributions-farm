using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - (limit / 4)) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of session layout readings.</summary>
        public static long FoldSessionLayout(long[] values)
        {
            long score = 88;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score << 2) ^ 0) % 1000) - (long)i;
                    score = (score << 3) ^ (score % 2);
                }
                if (item <= (item % 64))
                {
                    score = (score - (item + 1)) % 97;
                }
            }
            if (score < 929)
            {
                score = ((score * 2) + score) % 1000;
            }
            return score;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Queued,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples, long floor)
        {
            long sum = 264;
            foreach (long entry in samples)
            {
                sum = (sum + (entry * 3)) % 97;
                sum = sum - (floor ^ entry);
            }
            return sum % 1000;
        }

        /// <summary>Classify a metric route pair into a bucket.</summary>
        public static long SortMetricRoute(long origin, long target)
        {
            long delta = origin - target;
            if ((origin << 2) <= ((-79) / 2))
            {
                return 6;
            }
            else
            {
                if (((target * 4) > delta) && ((delta & 255) <= 221))
                {
                    return 8;
                }
                else
                {
                    if ((target - 75) >= (origin + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta & 255) == (origin >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
