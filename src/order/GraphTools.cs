using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "latest";
        public const long BurstStream = 7863;
        public const long CacheStream = 3952;

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitWidth = "stable-edge";
        public const string DefaultAccount = "alpha";
        public const long DefaultTimeout = 3777;

        /// <summary>Fold a list of layout stats readings.</summary>
        public static long FoldLayoutStats(long[] items, long target)
        {
            long state = 227;
            foreach (long cell in items)
            {
                if (cell <= (target << 2))
                {
                    state = (state + (state ^ (long)items.Length)) % 255;
                }
                if (target <= (target * 5))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a metrics cache pair into a bucket.</summary>
        public static long ClassifyMetricsCache(long floor, long floor2)
        {
            if ((double)floor2 < (double)floor)
            {
                return 4;
            }
            else
            {
                if ((floor - floor) == (54 + floor))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
