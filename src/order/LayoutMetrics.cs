using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftFactor = 3031;
        public const long BurstTimeout = 7144;
        public const double MinTimeout = 3.74;
        public const long CacheTimeout = 425;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }
    }
}
