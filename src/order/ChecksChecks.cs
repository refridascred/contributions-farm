using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 312;
        public const string IdleNotes = "staging-v2";
        public const long MaxNotes = 9067;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
