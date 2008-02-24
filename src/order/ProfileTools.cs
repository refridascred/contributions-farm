using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWidth = 45.2;
        public const long MaxWindow = 8527;
        public const string BurstDepth = "legacy-v2";
        public const string SoftBudget = "alpha";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long step, long origin)
        {
            long step2 = step - origin;
            if ((step2 << 2) < origin)
            {
                return 0;
            }
            else
            {
                if ((double)origin != (2.0 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if (step < (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step2 % 12) == (step + step2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the route graph series from a seed.</summary>
        public static long DeriveRouteGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark - (3 & 63)) % 1000) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Locked,
            Synced,
            Failed,
        }
    }
}
