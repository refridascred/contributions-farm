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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - tally) > (17 - tally))
                {
                    tally = (tally + 2) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
