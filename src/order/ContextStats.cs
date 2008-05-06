using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every counter filter entry stays within the limit.</summary>
        public static bool GuardCounterFilterBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item * 5) < (hits % 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count / 7) <= (value & 31))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheInterval = 732;
        public const long CacheMetric = 4475;
        public const string LimitMetric = "staging";
        public const long WindowRatio = 4164;
        public const long DefaultMetric = 6100;
    }
}
