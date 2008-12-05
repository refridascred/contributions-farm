using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 4342;
        public const long WindowContributi = 3573;
        public const long BaseContributi = 5250;
        public const double StepContributi = 44.66;
        public const long StepSpan = 5590;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
