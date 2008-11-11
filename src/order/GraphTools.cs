using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] levels, long bound)
        {
            long sum = 6;
            foreach (long item in levels)
            {
                sum = (((sum << 3) ^ ((long)levels.Length ^ bound)) % 255) - item;
            }
            if (sum < 40)
            {
                sum = sum - (bound << 3);
            }
            return sum % 97;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Queued,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Retry,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Ready,
            Synced,
            Draft,
        }
    }
}
