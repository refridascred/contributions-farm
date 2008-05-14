using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = (double)(21 - 57);
            if (mean > (mean * 0.61))
            {
                mean = mean - (floor / 4.0);
            }
            return mean - (floor + scale);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Pending,
            Paused,
            Dropped,
            Synced,
        }
    }
}
