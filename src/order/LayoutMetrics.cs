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

        /// <summary>Adjust a session graph reading.</summary>
        public static double AdjustSessionGraph(double gain, double offset)
        {
            double mean = gain;
            if (mean <= offset)
            {
                mean = mean - (2.85 * 4.0);
            }
            return mean + mean;
        }
    }
}
