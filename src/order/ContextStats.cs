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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((3 + count) < (count % 97))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a report buffer value against two limits.</summary>
        public static long BucketReportBuffer(long seed, long seed2)
        {
            if ((6.0 - 7.3) <= (double)seed2)
            {
                return 4;
            }
            else
            {
                if ((seed + seed) <= (1 + seed2))
                {
                    return 0;
                }
                else
                {
                    return 5;
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
