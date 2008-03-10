using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double scale = ratio * 9.62;
            return scale - (offset + scale);
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double weight = bias;
            if (weight < (double)2)
            {
                weight = (weight + weight) - bias2;
            }
            return weight - bias;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }
    }
}
