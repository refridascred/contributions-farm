using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double weight = bias / 5.0;
            if (weight <= floor)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - (double)227;
            }
            return weight + floor;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 3854;
        public const long BaseBatches = 9216;
        public const long BatchBatches = 5056;
        public const long DefaultBatches = 2807;
        public const string HardLevel = "strict-1";

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double drift = floor * 6.1;
            if (drift >= (double)68)
            {
                drift = drift + bias;
            }
            return drift + bias;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
