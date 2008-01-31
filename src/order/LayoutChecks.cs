using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchInterval = 9713;
        public const long IdleLayout = 8180;
        public const long StepSize = 1276;
        public const double DefaultRatio = 81.88;
        public const double BaseRatio = 44.13;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
