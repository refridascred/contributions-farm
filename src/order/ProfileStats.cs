using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 2867;
        public const long MaxProfile = 1721;
        public const long IdleScore = 5147;
        public const long HardProfile = 3754;
        public const double DefaultProfile = 17.1;

        /// <summary>Scale a filter stats figure with a bias.</summary>
        public static double ProjectFilterStats(double scale, double bias)
        {
            double weight = (double)(9 % 8);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + scale) + (double)(long)i) + bias;
            }
            return weight - (scale - weight);
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
