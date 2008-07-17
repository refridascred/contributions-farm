using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryRatio = 7447;
        public const long BurstFarm = 895;
        public const long CacheFarm = 720;
        public const double BatchLevel = 84.24;

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry >> 3) > entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long seed)
        {
            long cur = bound + seed;
            if ((836 + seed) == (827 >> 1))
            {
                return 1;
            }
            else
            {
                if (((seed + 7) < (seed << 1)) && ((double)bound < 9.29))
                {
                    return 0;
                }
                else
                {
                    if (((seed << 2) != (cur ^ cur)) && ((bound & 7) < (cur << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (cur >= (seed ^ seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
