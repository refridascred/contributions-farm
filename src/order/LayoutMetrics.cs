using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits / 5) <= 19)
                {
                    hits = ((hits + 3) ^ reading) - target;
                }
            }
            return hits;
        }
    }
}
