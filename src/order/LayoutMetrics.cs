using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowWidth = 3103;
        public const long IdleChannel = 7987;
        public const string DefaultScore = "primary";
        public const long IdleWidth = 9709;
        public const string MinSize = "strict";

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
