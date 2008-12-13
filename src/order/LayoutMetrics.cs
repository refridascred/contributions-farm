using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7175;
        public const long WindowLayout = 1325;
        public const double LimitLayout = 13.07;
        public const long SoftLayout = 6361;

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double gain = (double)(193 % 16);
            return (gain - floor) + bias;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
