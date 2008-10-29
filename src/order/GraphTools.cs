using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 64.47;
        public const long MaxChecks = 6652;
        public const string CacheChecks = "strict-v2";
        public const string BaseInterval = "primary";

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Synced,
            Queued,
            Closed,
            Done,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
