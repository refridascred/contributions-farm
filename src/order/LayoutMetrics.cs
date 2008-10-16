using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Synced,
            Paused,
        }
    }
}
