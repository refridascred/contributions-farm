using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 83.01;
        public const long CacheSize = 9396;
        public const long LimitScore = 8798;
        public const long CacheLevel = 7656;
        public const double StepCount = 82.47;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long AuditCommandReportOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((((long)samples.Length << 1) >= (value & 15)) || ((double)value >= (7.3 / 4.0))))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultCount = 2692;
        public const long SoftSpan = 8796;
        public const long SoftDepth = 5877;
        public const double CacheBuffer = 51.03;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
