using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Pending,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((7 - (long)data.Length) <= (tally % 97))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor counter entry stays within the limit.</summary>
        public static bool CheckEditorCounterRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
