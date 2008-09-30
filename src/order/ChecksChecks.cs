using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Total { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
