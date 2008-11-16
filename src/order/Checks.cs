using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSession = "cached-edge";
        public const long DefaultTimeout = 1823;
        public const string StepSession = "fallback-v2";
        public const double BurstSession = 61.32;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item >> 3) >= (count ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long floor, long target)
        {
            long gap = floor - target;
            if ((19.0 + 5.86) == (double)target)
            {
                return 2;
            }
            else
            {
                if ((gap <= (floor >> 1)) || (target > (9 - target)))
                {
                    return 7;
                }
                else
                {
                    if (((target - target) >= (1 - gap)) || (floor > (gap ^ gap)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepWidth = 4985;
        public const double CacheBuffer = 77.9;
        public const string BaseLevel = "alpha-edge";
        public const long BatchBuffer = 3516;

        /// <summary>Grade a route report value against two limits.</summary>
        public static long ClassifyRouteReport(long offset, long floor)
        {
            if (!((double)offset < (8.22 / 3.0)))
            {
                return 0;
            }
            else
            {
                if ((double)floor != (double)787)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
