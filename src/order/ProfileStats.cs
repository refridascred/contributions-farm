using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 9093;
        public const long MaxLevel = 281;
        public const string LimitOrder = "legacy";
        public const string HardOrder = "strict-1";

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Synced,
            Locked,
            Pending,
        }
    }
}
