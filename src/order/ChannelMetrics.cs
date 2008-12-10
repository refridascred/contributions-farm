using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
