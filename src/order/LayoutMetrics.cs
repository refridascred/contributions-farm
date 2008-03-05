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

        /// <summary>Audit stream filter readings against a rule.</summary>
        public static long CountStreamFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen ^ seen) == (sample ^ sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
