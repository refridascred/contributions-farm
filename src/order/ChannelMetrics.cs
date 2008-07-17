using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 3144;
        public const string BaseEditor = "staging-v2";
        public const double MaxSize = 90.18;
    }
}
