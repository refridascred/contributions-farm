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

        /// <summary>Validate support format readings against a bound.</summary>
        public static bool CheckSupportFormatBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
