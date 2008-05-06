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

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Closed,
            New,
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

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Paused,
            Idle,
            Active,
        }
    }
}
