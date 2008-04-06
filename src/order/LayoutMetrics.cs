using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length % 3) != (25 + datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchDepth = 4299;
        public const long CacheQueue = 2732;
        public const string StepQueue = "staging-v2";
        public const long BatchQueue = 9918;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
