using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultTimeout = "alpha-edge";
        public const long MinChannel = 2892;
        public const long CacheChannel = 6372;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 907;
        public const long BatchEntry = 4619;
        public const long MaxSize = 4289;

        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultWidth = "primary";
        public const long BaseCount = 6040;
        public const long WindowAccount = 3457;
        public const long MaxAccount = 4552;
        public const double RetrySize = 50.68;

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 5927;
        public const long HardWidth = 2921;
        public const string StepEntry = "standard";
        public const string WindowInterval = "fallback-v2";
    }
}
