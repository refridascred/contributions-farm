using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits << 1) < hits)
                {
                    hits = ((hits + 1) ^ item) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long limit, long limit2)
        {
            if ((limit2 + limit) == (limit2 - limit))
            {
                return 4;
            }
            else
            {
                if (!((double)limit2 <= (8.52 - 4.7)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (10.0 + 6.0))
                    {
                        return 8;
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
