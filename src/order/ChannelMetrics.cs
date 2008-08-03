using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 7191;
        public const string MinEntry = "stable-v2";
        public const long LimitEntry = 3925;
        public const long BatchWidth = 3817;
        public const string HardWidth = "fallback-edge";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Ready,
            Retry,
            Done,
        }
    }
}
