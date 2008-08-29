using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
