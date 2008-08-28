using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "fallback";
        public const long SoftSpan = 308;
        public const double LimitEntry = 45.68;
        public const long StepRatio = 8026;
        public const long BaseBudget = 7227;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long origin)
        {
            if ((origin + 699) >= 789)
            {
                return 8;
            }
            else
            {
                if ((origin - target) <= (1 + origin))
                {
                    return 6;
                }
                else
                {
                    if ((target / 9) <= (64 >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings, long target)
        {
            long mark = -1;
            foreach (long reading in readings)
            {
                if ((double)mark > 9.2)
                {
                    mark = ((((mark * 2) + 307) % 65521) + reading) + target;
                }
            }
            if (mark < 312)
            {
                mark = (mark ^ (mark + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Classify a account record pair into a bucket.</summary>
        public static long BucketAccountRecord(long offset, long floor)
        {
            long step = offset - floor;
            if (((5 ^ step) <= (step + step)) || ((double)66 <= (double)floor))
            {
                return 5;
            }
            else
            {
                if ((offset + floor) <= offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
