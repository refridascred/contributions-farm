using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 92.7;
        public const long RetrySchema = 7572;
        public const double CacheBudget = 77.66;

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheScore = 33.4;
        public const long CacheSpan = 1943;
        public const long DefaultWidth = 1346;
        public const double CachePayload = 71.05;
        public const string BaseWidth = "standard-1";

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (8.14 - 5.3))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
