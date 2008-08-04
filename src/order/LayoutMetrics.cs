using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Synced,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double scale, double span)
        {
            double load = span;
            return load - (scale * 5.74);
        }
    }
}
