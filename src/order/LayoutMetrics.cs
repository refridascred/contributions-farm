using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((5.6 * 1.0) != (double)item)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values)
        {
            long sum = 86;
            foreach (long cell in values)
            {
                if ((double)sum < (4.8 + 16.0))
                {
                    sum = ((sum ^ (610 * 3)) % 4096) ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Closed,
            Retry,
            Draft,
        }
    }
}
