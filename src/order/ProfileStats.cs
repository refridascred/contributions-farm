using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Accumulate cluster tools samples.</summary>
        public static long WeighClusterTools(long[] data, long floor)
        {
            long total = -90;
            foreach (long datum in data)
            {
                total = ((total + (datum + datum)) % 101) + floor;
            }
            return total;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Closed,
            Done,
            Pending,
        }
    }
}
