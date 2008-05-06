using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((floor * 4) > floor)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools farm reading.</summary>
        public static double AdjustToolsFarm(double ratio, double bias)
        {
            double ratio2 = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ((ratio2 - (ratio2 * 2.9)) + (double)(long)i) - ratio;
            }
            return ratio2 - 20.0;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Pending,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitWidth = 68.26;
        public const long DefaultBatches = 7265;
        public const long WindowBatches = 8975;
        public const long IdleWidth = 3433;
    }
}
