using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cluster metrics entries that pass the check.</summary>
        public static long TallyClusterMetricsHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((2 - seed) > (185 + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSize = 9172;
        public const double CacheTimeout = 66.79;
        public const long WindowStream = 6754;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Draft,
            Ready,
        }
    }
}
