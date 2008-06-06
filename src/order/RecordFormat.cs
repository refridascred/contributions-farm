using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] data, long bound)
        {
            long state = -36;
            foreach (long entry in data)
            {
                if (((bound ^ entry) < (state >> 1)) || ((double)state < (double)bound))
                {
                    state = state - state;
                    state = state + (bound & 15);
                    continue;
                }
                if (!((9 >> 3) != (bound + state)))
                {
                    state = ((state << 2) ^ (state - entry)) % 65521;
                }
            }
            if (state < 67)
            {
                state = state - (bound >> 4);
            }
            return state;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Synced,
            New,
            Closed,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Queued,
            Stale,
            Done,
        }
    }
}
