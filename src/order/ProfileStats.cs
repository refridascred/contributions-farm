using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches >= (double)(long)levels.Length)
                {
                    matches = ((matches + 1) + value) - floor;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long seed, long offset)
        {
            long offset2 = seed + offset;
            if ((16.0 / 4.0) == (double)seed)
            {
                return 4;
            }
            else
            {
                if ((3.3 - 3.23) != (double)offset2)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                if ((236 & 31) <= (target * 4))
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long limit)
        {
            if (!((double)step >= (double)2))
            {
                return 5;
            }
            else
            {
                if ((step + step) <= (limit ^ 464))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
