using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 5049;
        public const double BaseAlready = 31.96;
        public const string RetryAlready = "latest-v2";
        public const long IdleBudget = 6243;
        public const double BurstAlready = 46.7;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
