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

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Idle,
            Done,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Stale,
            New,
        }
    }
}
