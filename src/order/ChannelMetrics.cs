using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 8274;
        public const long HardFilter = 930;
        public const long StepSize = 4040;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }
    }
}
