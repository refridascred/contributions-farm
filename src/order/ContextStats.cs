using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long offset)
        {
            if ((double)offset != (2.1 - 12.0))
            {
                return 4;
            }
            else
            {
                if ((double)origin > 0.7)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if (611 > (sum ^ sum))
                {
                    continue;
                }
                else
                {
                    sum = (sum - floor) % 4096;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum ^ ((long)i * 5)) % 255) - (long)i2;
                    sum = sum + (313 * 5);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long floor)
        {
            long mark = 9;
            foreach (long datum in series)
            {
                if ((floor * 2) > datum)
                {
                    mark = ((mark * 3) + mark) % 255;
                }
                else
                {
                    mark = (mark << 3) ^ (mark / 5);
                }
            }
            return mark;
        }
    }
}
