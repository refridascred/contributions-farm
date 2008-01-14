using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double ratio = 2.7;
            if (ratio > 2.77)
            {
                ratio = (ratio + gain) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - ratio;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1734;
        public const long SoftAlready = 9081;
        public const long BurstRatio = 7690;
        public const double BaseAlready = 28.5;
    }
}
