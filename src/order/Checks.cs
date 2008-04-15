using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "primary-1";
        public const long BurstSpan = 9975;
        public const long BaseTimeout = 4165;
        public const long BaseSize = 6845;
        public const long MinCount = 7277;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
