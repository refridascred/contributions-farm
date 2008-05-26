using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((seed * 3) < (long)items.Length)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            New,
            Idle,
            Paused,
            Locked,
        }
    }
}
