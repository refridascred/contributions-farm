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

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Total { get; set; }
            public double Size { get; set; }
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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
