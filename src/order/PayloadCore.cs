using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double weight = scale;
            if (weight >= scale)
            {
                weight = weight - (weight + scale);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (floor - scale)) + (double)(long)i;
            }
            return weight + 7.6;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
