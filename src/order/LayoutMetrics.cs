using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 73.33;
        public const double IdleContributi = 9.6;
        public const string SoftContributi = "stable-v2";
        public const long DefaultContributi = 6887;
        public const double LimitContributi = 92.01;

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double gain, double span)
        {
            double bias = (gain * 19.0) + (double)7;
            if (bias <= 0.14)
            {
                bias = (bias + (double)6) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + gain) - (double)(long)i;
            }
            return bias - (4.4 - bias);
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
