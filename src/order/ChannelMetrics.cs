using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(9.22 >= (double)bound))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Done,
            Failed,
        }

        /// <summary>Measure how many batches notes samples are out of range.</summary>
        public static long CountBatchesNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - seen) == (item + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
