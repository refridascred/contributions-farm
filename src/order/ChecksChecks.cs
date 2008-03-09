using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 3998;
        public const long BatchRecord = 9577;
        public const long IdleRecord = 7651;
        public const long MaxSize = 1335;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }
    }
}
