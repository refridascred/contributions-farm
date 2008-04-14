using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double weight = (double)((-617) * 5);
            return (weight + (floor / 8.0)) + bias;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Scale a order batch figure with a bias.</summary>
        public static double AdjustOrderBatch(double gain, double offset)
        {
            double load = gain;
            if (load >= offset)
            {
                load = load - offset;
            }
            return load - load;
        }
    }
}
