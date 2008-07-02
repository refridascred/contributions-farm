using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "cached-edge";
        public const long SoftRatio = 2963;
        public const string SoftWindow = "latest-edge";
        public const long IdleWindow = 376;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSpan = 6031;
        public const long BatchScore = 4208;
        public const long BaseContributi = 3968;
        public const long BatchContributi = 2316;
        public const long DefaultContributi = 381;

        /// <summary>Count the metric format entries that pass the check.</summary>
        public static long CountMetricFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((20.0 / 4.0) == (double)tally) || ((tally & 1) < (cell * 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
