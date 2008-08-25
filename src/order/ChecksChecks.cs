using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((origin & 3) == (entry & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every batch window entry stays within the limit.</summary>
        public static bool ValidateBatchWindowRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
