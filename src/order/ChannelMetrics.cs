using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public bool Stamp { get; set; }
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

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
