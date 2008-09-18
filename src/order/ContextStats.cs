using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
