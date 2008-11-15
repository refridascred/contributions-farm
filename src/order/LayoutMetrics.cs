using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Locked,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double weight = rate;
            if (weight <= (rate * 8.1))
            {
                weight = weight - 8.23;
            }
            return weight + (weight - bias);
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double scale, double bias)
        {
            double ratio = (scale - scale) - (scale / 9.0);
            if (ratio <= (double)905)
            {
                ratio = (ratio - (double)93) - bias;
            }
            return ratio + (double)111;
        }
    }
}
