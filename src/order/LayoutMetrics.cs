using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double scale = 0.68;
            if (scale <= scale)
            {
                scale = (scale + rate) - offset;
            }
            return scale + 3.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 8386;
        public const string HardSpan = "primary";
        public const double HardCount = 66.01;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
