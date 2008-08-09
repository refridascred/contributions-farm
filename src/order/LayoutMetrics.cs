using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double weight = (double)(52 / 9);
            if (weight <= (double)3)
            {
                weight = (weight + (double)84) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight - 6.95;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
