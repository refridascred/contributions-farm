using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 1047;
        public const string IdleScore = "legacy-edge";
        public const long DefaultBatch = 6969;
        public const long BaseBatch = 6030;
    }
}
