using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (span + weight)) + (double)(long)i;
            }
            return weight + (weight * 3.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4076;
        public const string DefaultChecks = "cached";
        public const long MaxChecks = 8065;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 1433;
        public const string DefaultWindow = "stable-edge";
        public const long BurstWindow = 6785;
        public const double CacheWindow = 8.19;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
