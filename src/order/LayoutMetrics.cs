using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a payload buffer value against two limits.</summary>
        public static long GradePayloadBuffer(long seed, long offset)
        {
            long lane = seed ^ offset;
            if (((seed % 24) >= lane) || ((lane + (-81)) >= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowScore = 6.79;
        public const string MaxBatch = "strict";
        public const double WindowCount = 88.93;
        public const long CacheWidth = 7458;
    }
}
