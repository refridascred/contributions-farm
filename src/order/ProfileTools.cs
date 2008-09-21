using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = mark ^ ((long)i2 >> 1);
                }
                if (mark > (117 ^ seed))
                {
                    mark = ((mark * 3) + (seed << 1)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first schema support entry that matches the target.</summary>
        public static long LocateSchemaSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools commits input into a small class.</summary>
        public static long BucketToolsCommits(long bound, long bound2)
        {
            if ((9.0 - 3.5) != (double)bound2)
            {
                return 0;
            }
            else
            {
                if ((double)bound <= (6.9 / 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((842 + 827) >= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchDepth = 5047;
        public const long DefaultBudget = 7608;
        public const long StepTimeout = 5335;
        public const double WindowLevel = 2.24;
        public const long LimitPayload = 4644;
    }
}
