using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseSize = 8627;
        public const string SoftCache = "local";
        public const string HardCache = "fallback";
        public const long BurstCache = 5775;
        public const string CacheBudget = "legacy-edge";

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
