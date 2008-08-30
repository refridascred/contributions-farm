using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
