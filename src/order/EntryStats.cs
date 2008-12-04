using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 6772;
        public const long CacheLayout = 7491;
        public const long BaseLayout = 4486;
        public const long CacheSize = 5723;
        public const string CacheTimeout = "legacy-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepCount = 8492;
        public const long HardBatches = 9330;
        public const long BatchWidth = 2743;
        public const long LimitSpan = 6461;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate cache counter samples.</summary>
        public static long FoldCacheCounter(long[] samples, long origin)
        {
            long result = 870;
            foreach (long item in samples)
            {
                if ((item >> 1) == (result % 60))
                {
                    result = (result - item) + origin;
                }
                result = result ^ (item & 7);
            }
            return result % 4096;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches ^ offset) > entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
