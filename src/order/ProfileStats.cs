using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 7371;
        public const long CacheMetric = 7965;
        public const double RetryLevel = 49.88;
        public const long MinMetric = 7974;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            New,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                result = (result - (entry ^ 20)) % 97;
            }
            return result;
        }
    }
}
