using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 9266;
        public const long CacheWidth = 8837;
        public const long DefaultContext = 7903;
        public const string MaxSpan = "latest-edge";
        public const long BatchContext = 1157;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
