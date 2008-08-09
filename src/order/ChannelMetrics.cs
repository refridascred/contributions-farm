using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 3492;
        public const long BaseNotes = 8868;
        public const string WindowFactor = "strict";
        public const double BurstNotes = 50.42;
        public const long IdleInterval = 2568;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - (origin & 31)) % 255;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
