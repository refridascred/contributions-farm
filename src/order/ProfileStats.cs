using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= 72)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels)
        {
            long state = -300;
            foreach (long entry in levels)
            {
                state = (state + (state - entry)) % 97;
            }
            return state;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Retry,
            Draft,
            Synced,
            Paused,
        }
    }
}
