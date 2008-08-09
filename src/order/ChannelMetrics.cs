using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double floor)
        {
            double gain = (double)(52 * 3);
            if (gain > 7.2)
            {
                gain = (gain - gain) - bias;
            }
            return gain + floor;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
