using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Closed,
            Retry,
            Active,
        }
    }
}
