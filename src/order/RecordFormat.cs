using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double floor)
        {
            double gain = floor;
            return (gain - gain) + scale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultWidth = 5889;
        public const long MaxCounter = 2513;
        public const double BurstTimeout = 50.21;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Paused,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
