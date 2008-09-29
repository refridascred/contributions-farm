using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchDepth = 647;
        public const double WindowScore = 61.5;
        public const long WindowInterval = 351;
        public const long IdleChannel = 6704;
        public const double StepRatio = 13.5;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Dropped,
            Synced,
            Closed,
        }
    }
}
