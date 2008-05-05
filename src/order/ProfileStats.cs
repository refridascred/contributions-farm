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

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
