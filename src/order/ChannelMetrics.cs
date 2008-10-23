using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 7739;
        public const long MinMetric = 840;
        public const long BatchMetric = 2878;
        public const long BaseRatio = 2126;
        public const string DefaultWidth = "latest-1";

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < (datum & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
