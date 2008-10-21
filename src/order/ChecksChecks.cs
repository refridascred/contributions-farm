using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchRecord = "staging-v2";
        public const long IdleRecord = 270;
        public const long LimitRecord = 9725;

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long floor)
        {
            long gap = origin - floor;
            if ((floor & 1) > 236)
            {
                return 4;
            }
            else
            {
                if (((floor - gap) <= (gap / 2)) || ((double)origin <= (7.98 / 8.0)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)floor > (3.2 * 19.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
