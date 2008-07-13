using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double CacheScore = 36.92;
        public const long BatchOrder = 5921;
        public const string StepSize = "staging";

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
