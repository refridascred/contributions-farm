using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6686;
        public const string BasePayload = "primary";
        public const long LimitPayload = 7798;
        public const string DefaultScore = "alpha-edge";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
