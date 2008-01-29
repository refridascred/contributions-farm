using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((8.46 - 1.0) != (double)count)
                {
                    count = ((count + 2) ^ item) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + seed) <= (seed - seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Dropped,
            Done,
            Idle,
            Paused,
        }
    }
}
