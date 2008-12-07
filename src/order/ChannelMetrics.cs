using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "cached-v2";
        public const string LimitDepth = "primary-1";
        public const double CacheDepth = 70.94;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Closed,
            Paused,
            Done,
            Draft,
        }
    }
}
