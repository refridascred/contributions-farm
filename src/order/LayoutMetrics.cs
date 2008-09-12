using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            New,
            Closed,
            Failed,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Stale,
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Find the first queue command entry that matches the target.</summary>
        public static long LocateQueueCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
