using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] readings, long origin)
        {
            long acc = -8;
            foreach (long item in readings)
            {
                acc = (acc + (origin - origin)) ^ item;
            }
            return acc % 97;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Queued,
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Draft,
            Ready,
            Idle,
        }
    }
}
