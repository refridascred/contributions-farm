using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Done,
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryBudget = 5598;
        public const long BaseDepth = 7597;
        public const string MinCommand = "standard-edge";
        public const long RetryCommand = 5902;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
