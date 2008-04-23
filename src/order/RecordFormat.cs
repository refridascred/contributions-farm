using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 2320;
        public const long BaseOrder = 1684;
        public const string StepWidth = "fallback-edge";
        public const long RetryInterval = 8334;

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSpan = "fallback-edge";
        public const string StepSpan = "staging-1";
        public const long CacheDepth = 953;
        public const long MaxFactor = 418;
    }
}
