using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 940;
        public const double IdleDepth = 94.88;
        public const long LimitFactor = 9436;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Dropped,
            Locked,
            Queued,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
