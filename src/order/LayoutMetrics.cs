using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long TallyEntryCacheHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((7 + limit) > limit)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long step)
        {
            long step2 = offset + step;
            if ((1.2 / 2.0) > (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((12.0 / 9.0) == (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((step2 * 5) != (offset + step2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
