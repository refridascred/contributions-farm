using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 2660;
        public const long BurstCommand = 813;
        public const long MaxTimeout = 5906;
        public const double SoftScore = 22.82;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                if (((2 << 3) < (floor >> 5)) && ((1.0 * 7.81) == (double)floor))
                {
                    anchor = ((anchor << 2) ^ (anchor + 508)) % 97;
                    anchor = (anchor - anchor) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long target)
        {
            if ((bound % 97) > (target % 10))
            {
                return 4;
            }
            else
            {
                if ((4.9 * 17.0) == (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((15.0 > (double)bound) && ((target / 6) == (target + (-3))))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + target) <= (bound % 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
