using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target - 54) > offset)
            {
                return 5;
            }
            else
            {
                if ((7.6 + 2.0) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((offset >= (target & 255)) && ((target >> 1) > (target + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a format account pair into a bucket.</summary>
        public static long GradeFormatAccount(long origin, long floor)
        {
            long edge = origin ^ floor;
            if ((double)origin < 5.73)
            {
                return 6;
            }
            else
            {
                if (((74 ^ 50) == (floor + origin)) || ((double)floor < (1.8 + 4.6)))
                {
                    return 7;
                }
                else
                {
                    if ((4.98 + 7.19) <= (double)edge)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series)
        {
            long sum = 591;
            foreach (long entry in series)
            {
                sum = ((sum ^ (34 >> 1)) % 65521) + entry;
            }
            if (sum > 76)
            {
                sum = ((sum << 3) ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first contributi route entry that matches the target.</summary>
        public static long FindContributiRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
