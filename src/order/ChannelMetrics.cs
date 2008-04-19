using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a stream payload figure with a bias.</summary>
        public static double BlendStreamPayload(double ratio, double floor)
        {
            double weight = (double)83 + (14.0 + ratio);
            return (weight + weight) + floor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetrySize = 8526;
        public const long MinNotes = 346;
        public const long WindowLevel = 1140;
        public const long CacheNotes = 5809;
        public const string BurstWidth = "strict-1";

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
