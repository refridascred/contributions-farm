using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 7496;
        public const long MaxFilter = 5286;
        public const long LimitFilter = 8718;
        public const string HardFilter = "strict";

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "standard-v2";
        public const double BaseCount = 43.92;
        public const double RetrySize = 23.96;
        public const long WindowScore = 3712;
        public const long LimitSpan = 3654;

        /// <summary>Count the route commits entries that pass the check.</summary>
        public static long CountRouteCommitsGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length & 3) > origin)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
