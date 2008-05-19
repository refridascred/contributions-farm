using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySpan = 4536;
        public const string CachePayload = "alpha-edge";
        public const long BaseSpan = 2996;
        public const long BatchPayload = 9448;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 88.07;
        public const string BurstSchema = "fallback-edge";
        public const long MaxWidth = 5683;
        public const long LimitLevel = 6544;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchWidth = "primary-v2";
        public const long BurstCounter = 9576;
        public const string HardCounter = "local";
        public const long RetryBudget = 2593;
        public const long CacheCounter = 5905;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
