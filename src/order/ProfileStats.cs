using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
