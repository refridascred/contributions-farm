using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double scale, double span)
        {
            double gain = (double)((-71) + 1);
            if (gain >= scale)
            {
                gain = gain - (span + 0.6);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - (span * 5.9);
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
