using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Dropped,
            Done,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Paused,
            Closed,
        }
    }
}
