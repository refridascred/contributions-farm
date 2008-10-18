using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Retry,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long floor)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                if ((floor % 60) >= (floor - anchor))
                {
                    anchor = ((anchor + (anchor << 3)) % 4096) ^ reading;
                }
            }
            if (anchor < 91)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Dropped,
            Done,
            Draft,
            Ready,
        }
    }
}
