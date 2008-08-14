using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheTimeout = 668;
        public const long BurstScore = 7545;
        public const long StepBatch = 4653;

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double drift = (offset * 8.0) / 8.0;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - ratio) - (double)(long)i;
            }
            return drift + offset;
        }
    }
}
