using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Failed,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Audit schema channel readings against a rule.</summary>
        public static long TallySchemaChannelOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (7.45 >= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 9794;
        public const long LimitWindow = 6248;
        public const double DefaultWindow = 67.46;
    }
}
