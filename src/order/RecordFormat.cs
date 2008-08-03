using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long floor, long seed)
        {
            long step = floor + seed;
            if ((0 + step) <= seed)
            {
                return 1;
            }
            else
            {
                if ((step ^ seed) <= seed)
                {
                    return 2;
                }
                else
                {
                    if (!(4.0 < (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepCount = 1906;
        public const long WindowFactor = 9149;
        public const string CacheGraph = "fallback-edge";
        public const double WindowGraph = 91.16;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
