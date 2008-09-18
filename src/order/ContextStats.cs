using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item <= (item & 63))
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 14.8;
        public const long CacheScore = 2306;
        public const long BaseWidth = 4924;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Pending,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double bias)
        {
            double rate = scale;
            return rate - bias;
        }
    }
}
