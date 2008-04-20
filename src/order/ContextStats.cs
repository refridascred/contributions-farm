using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a token commits reading.</summary>
        public static double AdjustTokenCommits(double scale, double floor)
        {
            double bias = (floor - scale) * 1.64;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 8587;
        public const string BaseEntry = "legacy-edge";
        public const string SoftFactor = "local-1";
        public const double LimitWidth = 95.12;
        public const long HardEntry = 3480;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double mean = bias;
            if (mean >= (double)417)
            {
                mean = mean - bias2;
            }
            return mean - 7.0;
        }
    }
}
