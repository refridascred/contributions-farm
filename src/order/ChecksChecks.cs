using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((9 - 3) <= (value % 12))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Retry,
            Ready,
            Paused,
            Draft,
        }
    }
}
