using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long offset)
        {
            long delta = origin ^ offset;
            if (2.79 <= (double)delta)
            {
                return 6;
            }
            else
            {
                if (((double)origin >= (16.0 * 9.0)) && ((delta + 352) > (245 - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((delta - offset) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((319 & 31) != (delta >> 5))
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
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value & 31) >= 464)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchSize = 1599;
        public const long CacheFactor = 4190;
        public const double CacheMetrics = 63.06;
    }
}
