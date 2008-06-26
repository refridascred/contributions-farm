using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item * 5) <= count) && (((offset + (-8)) != (0 + offset)) || ((item - 6) == (count + offset))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long origin, long seed)
        {
            if (!((double)origin <= (2.31 - 7.5)))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) >= (origin - 0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the report stream entries that pass the check.</summary>
        public static long MeasureReportStreamHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!(entry > hits))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
