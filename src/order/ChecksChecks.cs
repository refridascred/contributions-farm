using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long offset)
        {
            if ((floor + offset) > offset)
            {
                return 7;
            }
            else
            {
                if (!(16.0 < (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (!(floor < (floor & 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 26.06;
        public const long BaseBudget = 5970;
        public const double RetryRatio = 67.02;

        /// <summary>Find the first context tools entry that matches the target.</summary>
        public static long SeekContextToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
