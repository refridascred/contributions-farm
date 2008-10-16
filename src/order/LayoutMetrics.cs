using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 48.26;
        public const long CacheMetrics = 8851;
        public const double MaxMetrics = 96.48;
        public const double WindowScore = 33.93;
        public const long HardMetrics = 4449;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            New,
            Done,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((4 * 3) != (tally + value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
