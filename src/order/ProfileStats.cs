using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double load = (floor * 2.0) + (floor - floor);
            if (load > (3.97 * 3.68))
            {
                load = (load - load) - gain;
            }
            return load + (double)43;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 8497;
        public const long StepMetrics = 8757;
        public const long CacheMetrics = 2723;
        public const long SoftSize = 3947;
        public const long WindowMetrics = 4583;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
