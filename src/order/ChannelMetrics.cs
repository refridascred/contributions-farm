using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double gain = (double)875;
            return (gain + (floor / 9.0)) + weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 4.36;
        public const long IdleFactor = 183;
        public const long BaseWindow = 6254;
        public const long RetryWindow = 6329;
    }
}
