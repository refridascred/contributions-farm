using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Active,
            New,
            Stale,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double bias = floor;
            if (bias > (double)27)
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - bias;
        }
    }
}
