using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 1876;
        public const double BatchWidth = 87.98;
        public const double CacheSize = 41.24;
        public const long DefaultSpan = 6558;
        public const long BurstEditor = 8484;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Paused,
            Dropped,
            Closed,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (7.37 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
