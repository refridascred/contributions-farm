using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double drift = (ratio + ratio) + ratio;
            if (drift < 6.4)
            {
                drift = (drift - (ratio / 9.0)) - bias;
            }
            return drift - drift;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 6752;
        public const double BurstRatio = 92.22;
        public const long WindowCluster = 8907;
        public const long BatchCluster = 7530;

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double gain = (bias - bias) - ratio;
            if (gain < (double)196)
            {
                gain = gain + (gain * 11.0);
            }
            return gain + (gain * 5.0);
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Active,
            Synced,
        }
    }
}
