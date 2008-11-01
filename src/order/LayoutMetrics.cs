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

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double mean = (double)86 - (6.1 * 20.0);
            if (mean < offset)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean - (mean * 5.1);
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
