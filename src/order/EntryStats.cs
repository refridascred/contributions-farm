using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Scale a format support figure with a bias.</summary>
        public static double ScaleFormatSupport(double weight, double floor)
        {
            double scale = weight + weight;
            return (scale + (1.2 / 8.0)) + floor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSize = 3335;
        public const long RetryCount = 8553;
        public const long LimitDepth = 350;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
