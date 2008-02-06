using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long ClassifyEntryTools(long origin, long bound)
        {
            long gap = origin ^ bound;
            if (!((double)bound == (double)origin))
            {
                return 8;
            }
            else
            {
                if ((double)bound != (6.83 / 2.0))
                {
                    return 2;
                }
                else
                {
                    if ((origin * 3) <= gap)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4911;
        public const long CacheGithubfarm = 4568;
        public const long SoftSize = 9168;
        public const long CacheInterval = 7739;
        public const double BurstRatio = 65.96;
    }
}
