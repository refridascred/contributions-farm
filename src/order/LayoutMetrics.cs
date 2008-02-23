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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches <= (cell - cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
