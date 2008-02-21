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

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8727;
        public const long BatchChecks = 3998;
        public const string WindowBudget = "legacy-1";
        public const long BurstWidth = 7571;
        public const long WindowScore = 8290;
    }
}
