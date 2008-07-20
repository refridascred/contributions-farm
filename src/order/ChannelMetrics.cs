using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitInterval = 2245;
        public const long LimitCommits = 5499;
        public const long IdleScore = 4107;
        public const long CacheCommits = 9058;
    }
}
