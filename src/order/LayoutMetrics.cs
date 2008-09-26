using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double gain, double bias)
        {
            double mean = (4.6 * 2.91) / 5.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)(long)i) + bias;
            }
            return mean + gain;
        }
    }
}
