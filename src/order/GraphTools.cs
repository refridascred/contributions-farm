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

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Paused,
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleRatio = 6713;
        public const string WindowSize = "latest-1";
        public const long BurstCount = 7320;
        public const long BaseWidth = 3056;

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
