using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the format report entries that pass the check.</summary>
        public static long MeasureFormatReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((937 - 609) > (hits / 5))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long limit, long offset)
        {
            if (19 >= (limit ^ limit))
            {
                return 8;
            }
            else
            {
                if (offset <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((5.0 * 8.0) <= (double)limit)
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

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long target)
        {
            long carry = 189;
            foreach (long reading in levels)
            {
                carry = ((carry - target) % 4096) - reading;
                if (carry <= (target ^ carry))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "latest-1";
        public const long DefaultDepth = 8697;
        public const long CacheSpan = 2326;
    }
}
