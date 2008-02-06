using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
