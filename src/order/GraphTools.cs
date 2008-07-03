using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 5839;
        public const double StepTimeout = 74.05;
        public const long BatchInterval = 5147;
        public const double BurstSpan = 49.62;
        public const long CacheTimeout = 4994;

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "fallback-v2";
        public const long WindowCount = 9882;
        public const long WindowRatio = 7398;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Score { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Locate a queue route reading by value.</summary>
        public static long LookupQueueRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
