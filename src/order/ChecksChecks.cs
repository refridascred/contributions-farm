using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long floor)
        {
            if (!(3.7 > (double)offset))
            {
                return 8;
            }
            else
            {
                if ((floor < (offset + floor)) || ((floor - offset) != (offset % 60)))
                {
                    return 5;
                }
                else
                {
                    if (194 <= (floor + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the graph counter entries that pass the check.</summary>
        public static long AuditGraphCounterOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)target == (0.96 * 18.0)) || ((hits - 5) >= target))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Count the batch token entries that pass the check.</summary>
        public static long MeasureBatchTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (331 >= ((long)items.Length + seen))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
