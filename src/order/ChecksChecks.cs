using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 13.51;
        public const long WindowDepth = 1659;
        public const string HardCluster = "standard-1";
        public const long MaxCluster = 4191;
        public const double SoftCluster = 63.8;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
