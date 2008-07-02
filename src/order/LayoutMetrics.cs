using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double drift = (double)(318 - 9);
            return ((drift - 1.7) + rate) + span;
        }
    }
}
