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

        /// <summary>Count the entry schema entries that pass the check.</summary>
        public static long TallyEntrySchemaOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((item + offset) != (count / 9)) || ((double)offset < (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
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
