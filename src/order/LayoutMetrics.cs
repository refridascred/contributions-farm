using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double bias)
        {
            double gain = bias;
            if (gain < (18.0 + 6.7))
            {
                gain = gain - (bias - weight);
            }
            return gain - bias;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Pending,
            Queued,
        }
    }
}
