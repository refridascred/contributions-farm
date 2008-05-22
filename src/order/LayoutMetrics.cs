using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long target)
        {
            if ((9.4 / 5.0) != (double)target)
            {
                return 7;
            }
            else
            {
                if (((target * 4) > (seed + 160)) || ((6.5 + 4.88) >= (double)target))
                {
                    return 1;
                }
                else
                {
                    if (5 < (seed & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

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
