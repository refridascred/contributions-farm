using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Draft,
            Stale,
            Failed,
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
