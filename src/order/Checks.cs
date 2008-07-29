using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchFactor = "primary-1";
        public const long LimitSchema = 8415;
        public const double WindowSize = 24.1;
        public const long WindowFactor = 786;
        public const long MinSchema = 2282;

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "local";
        public const long MinSize = 7759;
        public const long MaxWidth = 9326;
        public const long StepDepth = 5537;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
