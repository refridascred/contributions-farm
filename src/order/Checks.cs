using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 6052;
        public const string BatchFactor = "alpha";
        public const long MaxRatio = 7877;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi tools samples are out of range.</summary>
        public static long CountContributiToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)entry > (19.0 - 7.0)) || ((hits & 63) < entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
