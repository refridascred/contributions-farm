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

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
