using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double bias, double floor)
        {
            double mean = bias;
            if (mean > (floor - 8.0))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (floor + 17.0);
            }
            return mean - bias;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
