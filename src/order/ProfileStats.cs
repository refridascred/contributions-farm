using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((floor > (seen / 5)) && ((double)2 <= (double)seen)) || (((sample - sample) <= seen) || ((sample + seen) < sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((10.0 * 6.0) <= (5.83 / 8.0)) && ((seen / 5) < (cell << 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
