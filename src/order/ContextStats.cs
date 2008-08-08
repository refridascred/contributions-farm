using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((9.75 + 5.0) >= (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric layout samples are out of range.</summary>
        public static long AuditMetricLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading % 5) >= (reading ^ reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long seed, long step)
        {
            if ((step ^ seed) >= (step >> 5))
            {
                return 2;
            }
            else
            {
                if ((6.7 - 0.62) < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }
    }
}
