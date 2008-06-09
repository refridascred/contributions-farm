using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheFactor = 6044;
        public const long HardScore = 5702;
        public const long RetryFactor = 583;
        public const long HardFactor = 9615;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches & 127) <= matches)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a record metric value against two limits.</summary>
        public static long ClassifyRecordMetric(long bound, long limit)
        {
            if ((3.0 + 6.05) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound < 4.48)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
