using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long offset)
        {
            long total = 815;
            foreach (long item in samples)
            {
                total = (total + (item ^ item)) % 101;
            }
            if (total < 30)
            {
                total = (total ^ (offset << 1)) % 65521;
            }
            return total;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = 932;
            foreach (long cell in levels)
            {
                state = ((state - state) % 97) - cell;
            }
            return state % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the stream record entries that pass the check.</summary>
        public static long TallyStreamRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((4.7 + 14.0) > (double)datum) || ((double)hits >= (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
