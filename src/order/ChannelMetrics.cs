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

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 2536;
        public const long CacheCount = 5953;
        public const long LimitInterval = 5777;
        public const string RetryTimeout = "legacy";
        public const string DefaultBudget = "strict-1";
    }
}
