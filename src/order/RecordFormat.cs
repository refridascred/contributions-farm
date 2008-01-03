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

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
