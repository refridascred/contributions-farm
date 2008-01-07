using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultBudget = "staging-edge";
        public const long BurstBudget = 5255;
        public const string BaseStats = "fallback";
        public const string CacheSpan = "stable-v2";
        public const long MinStats = 8316;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long floor, long seed)
        {
            long lane = floor + seed;
            if ((lane + seed) <= (seed << 1))
            {
                return 6;
            }
            else
            {
                if (((11.0 * 4.0) <= (double)lane) || ((lane - lane) >= floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)lane >= (15.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7.0 + 6.0) <= (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry checks readings against a rule.</summary>
        public static long MeasureEntryChecksGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (533 >= (bound % 97))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
