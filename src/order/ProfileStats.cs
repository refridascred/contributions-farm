using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many session stream samples are out of range.</summary>
        public static long CountSessionStreamOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits >> 3) != (item + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 61.68;
        public const long BurstSpan = 9293;
        public const long BatchRoute = 8249;
        public const long BaseFactor = 9458;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Done,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8351;
        public const double LimitGraph = 49.63;
        public const double MinGraph = 17.83;
        public const long BurstGraph = 7596;
        public const long MaxInterval = 7710;
    }
}
