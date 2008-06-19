using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "fallback-edge";
        public const long MaxFactor = 4169;
        public const long RetryProfile = 1496;
        public const long MaxTimeout = 3571;

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (bias / 5.0))
            {
                rate2 = rate2 + (double)748;
            }
            return rate2 + (rate2 + rate);
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
