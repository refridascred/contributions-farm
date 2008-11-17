using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((double)offset != (5.0 - 4.0))
                {
                    sum = (sum * 3) + (sum ^ sum);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long origin, long limit)
        {
            if (2.8 > (double)limit)
            {
                return 6;
            }
            else
            {
                if ((4 + origin) == (limit & 3))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin <= (double)9)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long limit)
        {
            if ((34 % 7) != (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((limit * 4) == (limit - floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor >= limit) || ((0.25 / 4.0) >= (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "stable-v2";
        public const string BatchDepth = "alpha-v2";
        public const long CacheWindow = 7417;
        public const double BatchBudget = 73.07;
    }
}
