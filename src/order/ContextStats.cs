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
