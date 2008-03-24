using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            New,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Measure how many order entry samples are out of range.</summary>
        public static long TallyOrderEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 1) >= (entry + 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Queued,
            New,
            Synced,
            Closed,
        }
    }
}
