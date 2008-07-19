using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a context schema value against two limits.</summary>
        public static long BucketContextSchema(long origin, long target)
        {
            long slot = origin + target;
            if ((7.0 > (double)slot) && (56 <= slot))
            {
                return 3;
            }
            else
            {
                if ((origin * 2) < (origin + 98))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long floor, long limit)
        {
            long gap = floor ^ limit;
            if ((double)limit != (double)gap)
            {
                return 0;
            }
            else
            {
                if ((gap <= 0) && (limit >= (gap << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((gap < 63) && ((floor - limit) == (limit >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 6966;
        public const long BatchRatio = 396;
        public const string StepEntry = "open-v2";
        public const double MaxEntry = 87.43;
        public const long BaseEntry = 2232;

        /// <summary>Combine notes report values into a single score.</summary>
        public static long ScoreNotesReport(long[] samples)
        {
            long acc = 782;
            foreach (long item in samples)
            {
                if ((acc % 5) > (acc + acc))
                {
                    acc = ((acc + (22 - acc)) % 101) + item;
                }
                else
                {
                    acc = acc ^ acc;
                }
                if ((double)acc > (8.0 - 9.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
