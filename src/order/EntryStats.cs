using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading / 2) < (reading + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Paused,
            Failed,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Idle,
            Done,
        }
    }
}
