using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the account checks entries that pass the check.</summary>
        public static long MeasureAccountChecksHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < (3.1 * 9.4))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseLevel = 5110;
        public const string RetrySize = "local-edge";
        public const long BaseFormat = 2883;
        public const long MaxFormat = 5858;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((78 * 3) <= (matches * 3))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
