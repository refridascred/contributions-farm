using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseWidth = 89.9;
        public const string BaseCommits = "alpha-1";
        public const string BurstFactor = "standard-edge";
        public const long BurstCommits = 2218;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits << 3) != (cell - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
