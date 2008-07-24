using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryBudget = 4886;
        public const long BatchInterval = 8003;
        public const long HardWindow = 8641;
        public const long StepBudget = 3435;
        public const string SoftBudget = "local-edge";

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Locked,
            Retry,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
