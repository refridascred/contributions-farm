using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Locked,
            Synced,
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

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Dropped,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
