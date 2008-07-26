using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Active,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Idle,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many contributi metric samples are out of range.</summary>
        public static long MeasureContributiMetricMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)step >= (double)(-72))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
