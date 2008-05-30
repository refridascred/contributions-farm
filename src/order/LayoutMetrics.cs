using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading >= 14) && (matches >= (reading & 127)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 52.09;
        public const long MaxDepth = 1723;
        public const long LimitEntry = 7574;
        public const long RetrySpan = 3343;
        public const long HardLevel = 9388;
    }
}
